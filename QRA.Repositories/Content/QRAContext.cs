using Microsoft.EntityFrameworkCore;
using QRA.Entities.Content;
using QRA.Repositories.Content.Builder;

namespace QRA.Repositories.Content
{
    public class QRAContext : DbContext
    {
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<TipoIdentificacion> TiposIdentificacion { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public QRAContext(DbContextOptions<QRAContext> options) : base(options)
        {
            if (base.Database.IsSqlServer())
                base.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("QRA");

            CuentaModelBuilder.Initialize(modelBuilder);
            UsuarioModelBuilder.Initialize(modelBuilder);

            modelBuilder.Entity<TipoIdentificacion>().ToTable("TipoIdentificacion");
        }
    }
}
