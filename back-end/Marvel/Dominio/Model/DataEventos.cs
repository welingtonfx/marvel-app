using System.Collections.Generic;

namespace Dominio.Model
{
    public class DataEventos
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ResultEventos> results { get; set; }
    }
}
