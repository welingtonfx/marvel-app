using Dominio.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interface.Infra
{
    public interface IRepositorioMarvelDB
    {
        Task<IEnumerable<PersonagemDB>> ObterPersonagens();
        Task<PersonagemDB> ObterPersonagem(int id);
        Task<IEnumerable<QuadrinhoDB>> ObterQuadrinhos(int idPersonagem);
        Task<IEnumerable<EventoDB>> ObterEventos(int idPersonagem);
        Task<IEnumerable<SerieDB>> ObterSeries(int idPersonagem);
        Task<IEnumerable<HistoriaDB>> ObterHistorias(int idPersonagem);
    }
}
