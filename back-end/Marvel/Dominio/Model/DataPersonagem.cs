using System.Collections.Generic;

namespace Dominio.Model.Personagem
{
    public class DataPersonagem
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ResultPersonagem> results { get; set; }
    }
}
