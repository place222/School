using School.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace School.Web.Host.Controllers
{
    public class AntiForgeryController : SchoolControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}