using Abp.AspNetCore.Mvc.Authorization;
using School.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace School.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SchoolControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}