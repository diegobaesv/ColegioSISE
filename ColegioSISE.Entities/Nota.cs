using System;


namespace ColegioSISE.Entities
{
    public class Nota
    {
        public int IdNota { get; set; }
        public TipoNota TipoNota { get; set; }
        public Clase Clase { get; set; }
        public Alumno Alumno { get; set; }
        public float NotaObtenida { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
