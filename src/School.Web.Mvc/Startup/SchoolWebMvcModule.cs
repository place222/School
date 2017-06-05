using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using School.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace School.Web.Startup
{
    [DependsOn(typeof(SchoolWebCoreModule))]
    public class SchoolWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SchoolWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<SchoolNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolWebMvcModule).GetAssembly());
        }
    }
}