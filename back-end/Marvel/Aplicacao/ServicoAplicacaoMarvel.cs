using Dominio.Interface.Aplicacao;
using Dominio.Interface.Infra;
using Dominio.Model;
using Dominio.Model.Eventos;
using Dominio.Model.Historias;
using Dominio.Model.Personagem;
using Dominio.Model.Personagens;
using Dominio.Model.Quadrinhos;
using Dominio.Model.SeriesX;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class ServicoAplicacaoMarvel : IServicoAplicacaoMarvel
    {
        private readonly IRepositorioMarvel repositorioMarvel;

        public ServicoAplicacaoMarvel(IRepositorioMarvel repositorioMarvel)
        {
            this.repositorioMarvel = repositorioMarvel;
        }

        public async Task<Personagens> ObterPersonagens(CancellationToken cancellationToken)
        {
            // TODO retornar view model
            return await repositorioMarvel.ObterPersonagens(cancellationToken);
        }

        public async Task<Personagem> ObterPersonagem(int id, CancellationToken cancellationToken)
        {
            return await repositorioMarvel.ObterPersonagem(id, cancellationToken);
        }

        public async Task<Quadrinhos> ObterQuadrinhos(int id, CancellationToken cancellationToken)
        {
            return await repositorioMarvel.ObterQuadrinhos(id, cancellationToken);
        }

        public async Task<Eventos> ObterEventos(int id, CancellationToken cancellationToken)
        {
            return await repositorioMarvel.ObterEventos(id, cancellationToken);
        }

        public async Task<Series> ObterSeries(int id, CancellationToken cancellationToken)
        {
            return await repositorioMarvel.ObterSeries(id, cancellationToken);
        }

        public async Task<Historias> ObterHistorias(int id, CancellationToken cancellationToken)
        {
            return await repositorioMarvel.ObterHistorias(id, cancellationToken);
        }
    }
}
