using Dominio.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interface.Infra
{
    public interface IRepositorioMarvelDB
    {
        Task<IEnumerable<PersonagensViewModel>> ObterPersonagens();
        Task<PersonagemViewModel> ObterPersonagem(int id);
        Task<IEnumerable<QuadrinhoViewModel>> ObterQuadrinhos(int idPersonagem);
        Task<IEnumerable<EventoViewModel>> ObterEventos(int idPersonagem);
        Task<IEnumerable<SerieViewModel>> ObterSeries(int idPersonagem);
        Task<IEnumerable<HistoriaViewModel>> ObterHistorias(int idPersonagem);
    }
}
