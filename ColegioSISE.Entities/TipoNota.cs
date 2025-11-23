using System;

namespace ColegioSISE.Entities
{
    public class TipoNota
    {
        public int IdTipoNota { get; set; }
        public String Nombre { get; set; }
        public String Abreviacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
