using Dominio.Model;

namespace Dominio.ViewModel
{
    public class EventoViewModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string thumbnail { get; set; }

        public static explicit operator EventoViewModel(ResultEventos eventos)
        {
            return new EventoViewModel
            {
                id = eventos.id,
                title = eventos.title,
                description = eventos.description,
                resourceURI = eventos.resourceURI,
                start = eventos.start,
                end = eventos.end,
                thumbnail = eventos.thumbnail?.path ?? null
            };
        }
    }
}
