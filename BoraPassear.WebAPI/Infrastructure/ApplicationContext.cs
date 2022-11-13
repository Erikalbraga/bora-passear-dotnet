using BoraPassear.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BoraPassear.WebAPI.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
        }

        public DbSet<Motorista> Motoristas { get; set; }
    }
}
