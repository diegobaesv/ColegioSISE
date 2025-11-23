using System;

namespace ColegioSISE.Entities
{
    public class MatriculaClase
    {
        public Clase Clase { get; set; }
        public Alumno Alumno { get; set; }
        public String Estado { get; set; }
        public float PromedioFinal { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
