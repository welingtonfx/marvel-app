using System.Collections.Generic;

namespace Dominio.Model.Series
{
    public class DataSeries
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ResultSeries> results { get; set; }
    }
}
