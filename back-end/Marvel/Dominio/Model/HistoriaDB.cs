using Dominio.ViewModel;
using System;

namespace Dominio.Model
{
    public class HistoriaDB
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
        public string type { get; set; }
        public DateTime modified { get; set; }
        public string thumbnail { get; set; }

        public static explicit operator HistoriaViewModel(HistoriaDB historia)
        {
            return new HistoriaViewModel
            {
                id = historia.id,
                title = historia.title,
                description = historia.description,
                resourceURI = historia.resourceURI,
                type = historia.type,
                modified = historia.modified,
                thumbnail = historia.thumbnail
            };
        }
    }
}
