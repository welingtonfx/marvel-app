using System;
using System.Collections.Generic;

namespace Dominio.Model.Series
{
    public class ResultSeries
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
        public List<Url> urls { get; set; }
        public int startYear { get; set; }
        public int endYear { get; set; }
        public string rating { get; set; }
        public string type { get; set; }
        public DateTime modified { get; set; }
        public Thumbnail thumbnail { get; set; }
        public Creators creators { get; set; }
        public Characters characters { get; set; }
        public Stories stories { get; set; }
        public Comics comics { get; set; }
        public Events events { get; set; }
        public Next next { get; set; }
        public Previous previous { get; set; }
    }
}
