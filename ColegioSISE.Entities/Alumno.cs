using System;

namespace ColegioSISE.Entities
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public String Codigo { get; set; }
        public String Nombres { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String TipoDocumento { get; set; }
        public String NumeroDocumento { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
