using System;

namespace Dominio.Model.Historias
{
    public class ResultHistorias
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
        public string type { get; set; }
        public DateTime modified { get; set; }
        public object thumbnail { get; set; }
        public Creators creators { get; set; }
        public Characters characters { get; set; }
        public CharacterSeries series { get; set; }
        public Comics comics { get; set; }
        public Events events { get; set; }
        public OriginalIssue originalIssue { get; set; }
    }
}
