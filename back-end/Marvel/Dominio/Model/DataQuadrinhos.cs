using System.Collections.Generic;

namespace Dominio.Model.Quadrinhos
{
    public class DataQuadrinhos
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ResultQuadrinhos> results { get; set; }
    }
}
