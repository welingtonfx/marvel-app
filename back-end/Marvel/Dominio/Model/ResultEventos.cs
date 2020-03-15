using System;
using System.Collections.Generic;

namespace Dominio.Model
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
}
