using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using School.Users.Dto;

namespace School.Users
{
    public interface IUserAppService : IApplicationService
    {
        /// <summary>
        /// ��ֹȨ��
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task ProhibitPermission(ProhibitPermissionInput input);

        /// <summary>
        /// �Ƴ���ɫ
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task RemoveFromRole(long userId, string roleName);

        /// <summary>
        /// ��ȡ�û��б�
        /// </summary>
        /// <returns></returns>
        Task<ListResultDto<UserListDto>> GetUsers();

        /// <summary>
        /// �����û�
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateUser(CreateUserInput input);
    }
}