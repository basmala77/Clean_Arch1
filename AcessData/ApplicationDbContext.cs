using AccessData.Configuration;
using AcessData.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccessData
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
                base.OnModelCreating(builder);
            // Configure the IdentityRole entity
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new ApplicationUserConfiguration());

        }
    }
}