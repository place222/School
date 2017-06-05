using Abp.Domain.Repositories;
using Abp.Organizations;
using School.OrganizationUnits.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.OrganizationUnits
{
    /// <summary>
    /// 不做原型中的有关Code和状态这个
    /// </summary>
    public class OrganizationUnitAppService : SchoolAppServiceBase, IOrganizationUnitAppService
    {
        private readonly OrganizationUnitManager _organizationUnitManager;
        private readonly IRepository<OrganizationUnit, long> _organizationUnitRepository;
        public OrganizationUnitAppService(OrganizationUnitManager organizationUnitManager, IRepository<OrganizationUnit, long> organizationUnitRepository)
        {
            _organizationUnitManager = organizationUnitManager;
            _organizationUnitRepository = organizationUnitRepository;
        }

        /// <summary>
        /// 查找全部
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OrganizationUnitDto>> GetAll()
        {
            var list = await _organizationUnitManager.FindChildrenAsync(null, true);

            return ObjectMapper.Map<IEnumerable<OrganizationUnitDto>>(list);
        }

        /// <summary>
        /// 通过Id获取机构信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<OrganizationUnitDto> GetById(long id)
        {
            var org = await _organizationUnitRepository.GetAsync(id);

            return ObjectMapper.Map<OrganizationUnitDto>(org);
        }

        /// <summary>
        /// 创建机构
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task Create(CreateOrganizationUnitInput input)
        {
            await _organizationUnitManager.CreateAsync(ObjectMapper.Map<OrganizationUnit>(input));
        }

        /// <summary>
        /// 修改机构
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task Update(EditOrganizationUnitInput input)
        {
            var org = await _organizationUnitRepository.GetAsync(input.Id);

            org.DisplayName = input.DisplayName;
        }

        /// <summary>
        /// 删除机构
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(long id)
        {
            await _organizationUnitManager.DeleteAsync(id);
        }

    }
}
