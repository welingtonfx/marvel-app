using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Model.Eventos
{
    public class ResultEventos
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
        public List<Url> urls { get; set; }
        public DateTime modified { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public Thumbnail thumbnail { get; set; }
        public Creators creators { get; set; }
        public Characters characters { get; set; }
        public Stories stories { get; set; }
        public Comics comics { get; set; }
        public CharacterSeries series { get; set; }
        public Next next { get; set; }
        public Previous previous { get; set; }
    }

    public class DataEventos
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ResultEventos> results { get; set; }
    }

    public class Eventos
    {
        public int code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public string etag { get; set; }
        public DataEventos data { get; set; }
    }
}
