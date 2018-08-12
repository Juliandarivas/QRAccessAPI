using Microsoft.EntityFrameworkCore;
using QRA.Entities.Content;
using QRA.Repositories.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static QRA.Enumerators.Content.CuentaEnumerador;

namespace QRA.Migrations.Content
{
    public class DbInitializer
    {
        public static void Initialize(QRAContext context)
        {
            context.Database.Migrate();
            context.Database.EnsureCreated();

            if (context.TiposIdentificacion.Any())
            {
                return;
            }

            if (context.Usuarios.Any())
            {
                return;
            }

            if (context.Cuentas.Any())
            {
                return;
            }

            List<TipoIdentificacion> tiposIdentificacion = new List<TipoIdentificacion>
            {
                new TipoIdentificacion
                {
                    Id = 1,
                    Descripcion = "Cedula de Ciudadanía",
                },
                new TipoIdentificacion
                {
                    Id = 2,
                    Descripcion = "Tarjeta de Identidad",
                },
                new TipoIdentificacion
                {
                    Id = 3,
                    Descripcion = "Registro Civil",
                },
                new TipoIdentificacion
                {
                    Id = 4,
                    Descripcion = "Cédula de Extranjería",
                }
            };

            Usuario usuario = new Usuario
            {
                Id = 1,
                Identificacion = "001",
                IdTipoIdentificacion = 1,
                Apellidos = "Access",
                Nombres = "QR",
                FechaNacimiento = new DateTime(),
                Movil = null,
                Telefono = null,
                Direccion = null,
                CorreoElectronico = null
            };

            Cuenta cuenta = new Cuenta
            {
                Id = 1,
                IdUsuario = 1,
                NombreUsuario = "Adminqra",
                Clave = "qwerty",
                Estado = EstadoCuenta.Inactivo,
                FechaRegistro = DateTime.Now
            };

            context.AddRange(tiposIdentificacion);
            context.Add(usuario);
            context.Add(cuenta);

            context.SaveChanges();
        }
    }
}
