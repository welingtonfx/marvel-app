using Dominio.Model.Personagens;
using System;

namespace Dominio.ViewModel
{
    public class PersonagensViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime modified { get; set; }
        public string thumbnail { get; set; }

        public static explicit operator PersonagensViewModel(ResultPersonagens personagens)
        {
            return new PersonagensViewModel
            {
                id = personagens.id,
                name = personagens.name,
                description = personagens.description,
                modified = personagens.modified,
                thumbnail = personagens.thumbnail?.path ?? null
            };
        }
    }
}
