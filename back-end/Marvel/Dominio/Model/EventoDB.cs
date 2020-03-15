using Dominio.ViewModel;

namespace Dominio.Model
{
    public class EventoDB
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string thumbnail { get; set; }

        public static explicit operator EventoViewModel(EventoDB eventos)
        {
            return new EventoViewModel
            {
                id = eventos.id,
                title = eventos.title,
                description = eventos.description,
                resourceURI = eventos.resourceURI,
                start = eventos.start,
                end = eventos.end,
                thumbnail = eventos.thumbnail
            };
        }
    }
}
