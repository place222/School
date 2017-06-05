using Abp.AspNetCore.Mvc.Authorization;
using School.Authorization;
using School.Controllers;
using School.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace School.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : SchoolControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}