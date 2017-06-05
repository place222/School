using System.Threading.Tasks;
using Abp.Application.Services;
using School.Roles.Dto;
using Abp.Application.Services.Dto;

namespace School.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto>
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
