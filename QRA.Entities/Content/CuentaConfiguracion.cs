using System;
using System.Collections.Generic;
using System.Text;

namespace QRA.Entities.Content
{
    public class CuentaConfiguracion
    {  
        public int Id { get; set; }
        public int IdCuenta { get; set; }
        public string Clave { get; set; }
        public DateTime FechaInicio { get; set; }
        public string TokenActivacion { get; set; }
        public string TokenReset { get; set; }
        public DateTime FechaVencimientoToken { get; set; }

    }
}
