using System;
using System.Collections.Generic;
using System.Text;

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

    public class DataHistorias
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ResultHistorias> results { get; set; }
    }

    public class Historias
    {
        public int code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public string etag { get; set; }
        public DataHistorias data { get; set; }
    }
}
