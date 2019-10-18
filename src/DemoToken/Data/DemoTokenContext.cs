using DemoToken.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoToken.Data
{
    public class DemoTokenContext : IdentityDbContext
    {
        public DemoTokenContext(DbContextOptions<DemoTokenContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
