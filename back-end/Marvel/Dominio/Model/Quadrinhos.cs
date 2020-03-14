﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Model.Quadrinhos
{
    public class ResultQuadrinhos
    {
        public int id { get; set; }
        public int digitalId { get; set; }
        public string title { get; set; }
        public int issueNumber { get; set; }
        public string variantDescription { get; set; }
        public string description { get; set; }
        public object modified { get; set; }
        public string isbn { get; set; }
        public string upc { get; set; }
        public string diamondCode { get; set; }
        public string ean { get; set; }
        public string issn { get; set; }
        public string format { get; set; }
        public int pageCount { get; set; }
        public List<object> textObjects { get; set; }
        public string resourceURI { get; set; }
        public List<Url> urls { get; set; }
        public CharacterSeries series { get; set; }
        public List<object> variants { get; set; }
        public List<object> collections { get; set; }
        public List<object> collectedIssues { get; set; }
        public List<Date> dates { get; set; }
        public List<Price> prices { get; set; }
        public Thumbnail thumbnail { get; set; }
        public List<object> images { get; set; }
        public Creators creators { get; set; }
        public Characters characters { get; set; }
        public Stories stories { get; set; }
        public Events events { get; set; }
    }

    public class DataQuadrinhos
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ResultQuadrinhos> results { get; set; }
    }

    public class Quadrinhos
    {
        public int code { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public string attributionText { get; set; }
        public string attributionHTML { get; set; }
        public string etag { get; set; }
        public DataQuadrinhos data { get; set; }
    }
}