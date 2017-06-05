using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using School.Authorization;
using School.Controllers;
using School.Users;
using Microsoft.AspNetCore.Mvc;

namespace School.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : SchoolControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}