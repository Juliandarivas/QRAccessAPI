using System;
using System.Collections.Generic;
using System.Text;

namespace QRA.Entities.Content
{
    public class CodigoCuenta
    {
        public int Id { get; set; }
        public int IdCuenta { get; set; }
        public int IdCodigo { get; set; }
        public int Estado { get; set; }
        public bool Activo { get; set; }


        public virtual Codigo Codigo { get; set; }
        public virtual Cuenta Cuenta { get; set; }
    }
}
