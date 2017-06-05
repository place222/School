using Abp.Authorization;
using School.Authorization.Roles;
using School.Authorization.Users;
using School.MultiTenancy;

namespace School.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
