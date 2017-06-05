using Abp.Application.Services;
using Abp.Organizations;
using School.OrganizationUnits.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.OrganizationUnits
{
    public interface IOrganizationUnitAppService : IApplicationService
    {
        Task<IEnumerable<OrganizationUnitDto>> GetAll();

        Task<OrganizationUnitDto> GetById(long id);

        Task Create(CreateOrganizationUnitInput input);

        Task Update(EditOrganizationUnitInput input);

        Task Delete(long id);
    }
}
