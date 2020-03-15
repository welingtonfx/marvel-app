using Dominio.Model.Series;
using System;

namespace Dominio.ViewModel
{
    public class SerieViewModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
        public int startYear { get; set; }
        public int endYear { get; set; }
        public string rating { get; set; }
        public string type { get; set; }
        public string modified { get; set; }
        public string thumbnail { get; set; }

        public static explicit operator SerieViewModel(ResultSeries s)
        {
            return new SerieViewModel
            {
                id = s.id,
                title = s.title,
                description = s.description,
                resourceURI = s.resourceURI,
                startYear = s.startYear,
                endYear = s.endYear,
                rating = s.rating,
                type = s.type,
                modified = s.modified,
                thumbnail = s.thumbnail?.path ?? null
            };
        }
    }
}
