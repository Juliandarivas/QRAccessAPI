using Microsoft.EntityFrameworkCore;
using QRA.Entities.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace QRA.Repositories.Content.Builder
{
    public static class CuentaBuilder
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>()
                .ToTable("Cuenta");

            modelBuilder.Entity<Cuenta>()
                .HasKey(table => new { table.Id, table.IdUsuario })
                .ForSqlServerIsClustered(true);

            modelBuilder.Entity<Cuenta>()
                .Property(table => table.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<Cuenta>()
                .Property(table => table.NombreUsuario)
                .HasColumnType("VARCHAR(50)");

            modelBuilder.Entity<Cuenta>()
                .Property(table => table.Clave)
                .HasColumnType("VARCHAR(100)");

            modelBuilder.Entity<Cuenta>()
                .Property(table => table.FechaRegistro)
                .HasColumnType("SMALLDATETIME");
        }
    }
}
