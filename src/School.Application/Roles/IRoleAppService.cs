using System.Threading.Tasks;
using Abp.Application.Services;
using School.Roles.Dto;

namespace School.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
