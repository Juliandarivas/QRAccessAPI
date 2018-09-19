using System;
using System.Collections.Generic;
using System.Text;

namespace QRA.Entities.Content
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Jerarquia { get; set; }
        public bool Activo { get; set; }
        public string NivelAcceso { get; set; }
    }
}
