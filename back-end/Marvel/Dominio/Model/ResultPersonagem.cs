﻿using System;
using System.Collections.Generic;

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
}
