using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models.FluentAPI
{
    public class eCommerceFluentContext : DbContext
    {
        public eCommerceFluentContext(DbContextOptions<eCommerceFluentContext> options) : base(options)
        {
             
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<EnderecoEntrega> EndrecosEntrega { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("TB_USUARIOS");
            modelBuilder.Entity<Usuario>().Property(a => a.RG).HasColumnName("REGISTRO_GERAL").HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Usuario>().Ignore(a => a.Sexo);
            modelBuilder.Entity<Usuario>().Property(a => a.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Usuario>().HasIndex(a => new { a.CPF, a.Email });
            modelBuilder.Entity<Usuario>().HasIndex("Nome").IsUnique();

            modelBuilder.Entity<Usuario>().HasKey(a => a.Id);


            modelBuilder.Entity<Usuario>().HasOne(a => a.Contato).WithOne(a => a.Usuario).HasForeignKey<Contato>(a => a.UsuarioId);
            modelBuilder.Entity<Usuario>().HasMany(usu => usu.EnderecosEntrega).WithOne(end => end.Usuario);
            modelBuilder.Entity<Usuario>().HasMany(usu => usu.Departamentos).WithMany(dep => dep.Usuarios);
        }
    }
}
