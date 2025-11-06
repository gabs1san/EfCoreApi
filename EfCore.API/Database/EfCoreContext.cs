using Microsoft.EntityFrameworkCore;

namespace EfCore.API.Database
{
    public class EfCoreContext : DbContext
    {
       

        public EfCoreContext(DbContextOptions<EfCoreContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<EnderecoEntrega> EndrecosEntrega { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
