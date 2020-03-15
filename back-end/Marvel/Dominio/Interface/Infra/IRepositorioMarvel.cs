using Dominio.Model;
using Dominio.Model.Eventos;
using Dominio.Model.Historias;
using Dominio.Model.Personagem;
using Dominio.Model.Personagens;
using Dominio.Model.Quadrinhos;
using Dominio.Model.Series;
using System.Threading;
using System.Threading.Tasks;

namespace Dominio.Interface.Infra
{
    public interface IRepositorioMarvel
    {
        Task<Personagens> ObterPersonagens(CancellationToken cancellationToken);
        Task<Personagem> ObterPersonagem(int id, CancellationToken cancellationToken);
        Task<Quadrinhos> ObterQuadrinhos(int id, CancellationToken cancellationToken);
        Task<Eventos> ObterEventos(int id, CancellationToken cancellationToken);
        Task<Series> ObterSeries(int id, CancellationToken cancellationToken);
        Task<Historias> ObterHistorias(int id, CancellationToken cancellationToken);
    }
}
