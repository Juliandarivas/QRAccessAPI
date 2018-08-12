using System;

namespace QRA.Entities.Content
{
    public class Usuario
    {
        public int Id { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public string Movil { get; set; }
        public string Telefono { get; set; }
    }
}
