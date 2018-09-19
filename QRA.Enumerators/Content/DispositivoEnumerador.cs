using System;
using System.Collections.Generic;
using System.Text;

namespace QRA.Enumerators.Content
{
    public class DispositivoEnumerador
    {
        public enum AccionDispositivo
        {
            Salida = 0,
            Entrada = 1,
            EntradaYSalida = 2
        }

        public enum EstadoDispositivo
        {
            Inactivo = 0,
            Activo = 1
        }
    }
}
