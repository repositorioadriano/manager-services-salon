using Microsoft.EntityFrameworkCore;

namespace ManagerSalon.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Servico> Servicos {get;set;}
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}