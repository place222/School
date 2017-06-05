using School.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace School.Web.Controllers
{
    public class AboutController : SchoolControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}