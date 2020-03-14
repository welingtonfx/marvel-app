using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Model.Personagem
{
    public class ResultPersonagem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime modified { get; set; }
        public Thumbnail thumbnail { get; set; }
        public string resourceURI { get; set; }
        public Comics comics { get; set; }
        public CharacterSeries series { get; set; }
        public Stories stories { get; set; }
        public Events events { get; set; }
        public List<Url> urls { get; set; }
    }

    public class DataPersonagem
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ResultPersonagem> results { get; set; }
    }

    public class Personagem
    {
        public int code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public string etag { get; set; }
        public DataPersonagem data { get; set; }
    }
}
