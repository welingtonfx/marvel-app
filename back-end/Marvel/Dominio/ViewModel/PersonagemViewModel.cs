using Dominio.Model.Personagem;
using System;

namespace Dominio.ViewModel
{
    public class PersonagemViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime modified { get; set; }
        public string thumbnail { get; set; }

        public static explicit operator PersonagemViewModel(ResultPersonagem personagem)
        {
            return new PersonagemViewModel
            {
                id = personagem.id,
                name = personagem.name,
                description = personagem.description,
                modified = personagem.modified,
                thumbnail = personagem.thumbnail?.path ?? null
            };
        }
    }
}
