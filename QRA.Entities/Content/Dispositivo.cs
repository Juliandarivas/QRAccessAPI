using System;
using System.Collections.Generic;
using System.Text;
using static QRA.Enumerators.Content.DispositivoEnumerador;

namespace QRA.Entities.Content
{
    public class Dispositivo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Tipo {get; set;}
        public AccionDispositivo Accion { get; set; }
        public EstadoDispositivo Estado { get; set; }
        public string IP { get; set; }
        public string GPS { get; set; }
    }
}
