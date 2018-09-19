using System;
using System.Collections.Generic;
using System.Text;
using static QRA.Enumerators.Content.AccesoEnumerador;

namespace QRA.Entities.Content
{
    public class Acceso
    {
        public int Id { get; set; }
        public int IdCuenta { get; set; }
        public int IdDispositivo { get; set; }
        public AccionAcceso Accion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
