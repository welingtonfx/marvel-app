using Dominio.Model.Historias;
using System;

namespace Dominio.ViewModel
{
    public class HistoriaViewModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
        public string type { get; set; }
        public DateTime modified { get; set; }
        public string thumbnail { get; set; }

        public static explicit operator HistoriaViewModel(ResultHistorias historias)
        {
            return new HistoriaViewModel
            {
                id = historias.id,
                title = historias.title,
                description = historias.description,
                resourceURI = historias.resourceURI,
                type = historias.type,
                modified = historias.modified,
                thumbnail = historias.thumbnail != null ? historias.thumbnail.ToString() : null
            };
        }
    }
}
