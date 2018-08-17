using Microsoft.EntityFrameworkCore;
using QRA.Entities.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace QRA.Repositories.Content.Builder
{
    public static class UsuarioModelBuilder
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario");

            modelBuilder.Entity<Usuario>()
                .HasKey(table => table.Id);

            modelBuilder.Entity<Usuario>()
                .Property(table => table.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<Usuario>()
                .Property(table => table.Identificacion)
                .HasColumnType("VARCHAR(20)");

            modelBuilder.Entity<Usuario>()
                .Property(table => table.Apellidos)
                .HasColumnType("VARCHAR(30)");

            modelBuilder.Entity<Usuario>()
                .Property(table => table.Nombres)
                .HasColumnType("VARCHAR(30)");

            modelBuilder.Entity<Usuario>()
                .Property(table => table.FechaNacimiento)
                .HasColumnType("SMALLDATETIME");

            modelBuilder.Entity<Usuario>()
                .Property(table => table.CorreoElectronico)
                .HasColumnType("VARCHAR(50)");

            modelBuilder.Entity<Usuario>()
                .Property(table => table.Direccion)
                .HasColumnType("VARCHAR(100)");

            modelBuilder.Entity<Usuario>()
                .Property(table => table.Movil)
                .HasColumnType("VARCHAR(20)");

            modelBuilder.Entity<Usuario>()
                .Property(table => table.Telefono)
                .HasColumnType("VARCHAR(20)");
        }
    }
}
