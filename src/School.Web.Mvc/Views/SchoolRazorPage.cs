using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace School.Web.Views
{
    public abstract class SchoolRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SchoolRazorPage()
        {
            LocalizationSourceName = SchoolConsts.LocalizationSourceName;
        }
    }
}
