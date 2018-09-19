using System;
using System.Collections.Generic;
using System.Text;

namespace QRA.Entities.Content
{   
    public class Codigo
    {
        public int Id { get; set; }
        public int IdCuenta { get; set; }
        public int Estado { get; set; }
        public string Identificador { get; set; }
        public string Token { get; set; }

        public virtual Cuenta Cuenta { get; set; }
    }
}
