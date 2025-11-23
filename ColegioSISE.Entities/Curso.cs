using System;

namespace ColegioSISE.Entities
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public Carrera Carrera { get; set; }
        public int Ciclo { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int CantidadMatriculados { get; set; }
    }
}
