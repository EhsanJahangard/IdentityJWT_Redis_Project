using Microsoft.EntityFrameworkCore;
using IdentityJWTProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityJWTProject.Data
{
    public class JWTContext : IdentityDbContext<AppUser>
    {
        protected readonly IConfiguration _configuration;
        public JWTContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("JWTContextConnection"));
        }
        public DbSet<Product> Products
        {
            get;
            set;
        }
    }
}
