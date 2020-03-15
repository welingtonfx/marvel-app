using Dominio.ViewModel;
using System;

namespace Dominio.Model
{
    public class PersonagemDB
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime modified { get; set; }
        public string thumbnail { get; set; }

        public static explicit operator PersonagemViewModel(PersonagemDB personagem)
        {
            return new PersonagemViewModel
            {
                id = personagem.id,
                name = personagem.name,
                description = personagem.description,
                modified = personagem.modified,
                thumbnail = personagem.thumbnail
            };
        }
    }
}
