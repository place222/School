using School.Configuration;
using School.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace School.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SchoolDbContextFactory : IDbContextFactory<SchoolDbContext>
    {
        public SchoolDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<SchoolDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SchoolDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SchoolConsts.ConnectionStringName));
            
            return new SchoolDbContext(builder.Options);
        }
    }
}