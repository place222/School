using Microsoft.EntityFrameworkCore;

namespace School.EntityFrameworkCore
{
    public static class SchoolDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SchoolDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}