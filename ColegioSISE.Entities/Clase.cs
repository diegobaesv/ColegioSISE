using System;


namespace ColegioSISE.Entities
{
    public class Clase
    {
        public int IdClase { get; set; }
        public Curso Curso { get; set; }
        public Docente Docente { get; set; }
        public String UrlTeams { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
