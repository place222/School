using Abp.Zero.EntityFrameworkCore;
using School.Authorization.Roles;
using School.Authorization.Users;
using School.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace School.EntityFrameworkCore
{
    public class SchoolDbContext : AbpZeroDbContext<Tenant, Role, User, SchoolDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //...
        }
    }
}
