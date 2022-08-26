using Microsoft.EntityFrameworkCore;
using IdentityJWTProject.Models;
namespace IdentityJWTProject.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration _configuration;
        public DbContextClass(IConfiguration configuration)
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
