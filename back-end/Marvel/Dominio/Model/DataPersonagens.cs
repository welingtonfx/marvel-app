using System.Collections.Generic;

namespace Dominio.Model.Personagens
{
    public class DataPersonagens
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ResultPersonagens> results { get; set; }
    }
}
