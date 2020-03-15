using Dominio.ViewModel;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Dominio.Interface.Aplicacao
{
    public interface IServicoAplicacaoMarvel
    {
        Task<IEnumerable<PersonagensViewModel>> ObterPersonagens(CancellationToken cancellationToken);
        Task<IEnumerable<PersonagemViewModel>> ObterPersonagem(int id, CancellationToken cancellationToken);
        Task<IEnumerable<QuadrinhoViewModel>> ObterQuadrinhos(int id, CancellationToken cancellationToken);
        Task<IEnumerable<EventoViewModel>> ObterEventos(int id, CancellationToken cancellationToken);
        Task<IEnumerable<SerieViewModel>> ObterSeries(int id, CancellationToken cancellationToken);
        Task<IEnumerable<HistoriaViewModel>> ObterHistorias(int id, CancellationToken cancellationToken);
    }
}
