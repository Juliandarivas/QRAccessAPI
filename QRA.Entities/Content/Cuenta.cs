﻿using System;
using static QRA.Enumerators.Content.CuentaEnumerador;

namespace QRA.Entities.Content
{
    public class Cuenta
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public TipoCuenta Tipo { get; set; }
        public EstadoCuenta Estado { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual Codigo Codigo { get; set; }
    }
}
