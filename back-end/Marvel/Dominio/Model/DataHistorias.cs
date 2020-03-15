using System.Collections.Generic;

namespace Dominio.Model.Historias
{
    public class DataHistorias
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ResultHistorias> results { get; set; }
    }
}
