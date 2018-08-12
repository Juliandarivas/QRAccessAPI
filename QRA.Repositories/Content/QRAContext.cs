using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QRA.Entities.Content;

namespace QRA.Repositories.Content
{
    public class QRAContext : DbContext
    {
        public DbSet<TipoIdentificacion> TiposIdentificacion { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }

        public QRAContext(DbContextOptions<QRAContext> options) : base(options)
        {   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("QRA");
            modelBuilder.Entity<TipoIdentificacion>().ToTable("TipoIdentificacion");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Cuenta>().ToTable("Cuenta");
        }
    }
}
