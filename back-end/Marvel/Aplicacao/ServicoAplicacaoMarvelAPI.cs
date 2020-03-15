using Dominio.Interface.Aplicacao;
using Dominio.Interface.Infra;
using Dominio.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class ServicoAplicacaoMarvelAPI : IServicoAplicacaoMarvelAPI
    {
        private readonly IRepositorioMarvelAPI repositorioMarvel;

        public ServicoAplicacaoMarvelAPI(IRepositorioMarvelAPI repositorioMarvel)
        {
            this.repositorioMarvel = repositorioMarvel;
        }

        public async Task<IEnumerable<PersonagensViewModel>> ObterPersonagens(CancellationToken cancellationToken)
        {
            var personagens = await repositorioMarvel.ObterPersonagens(cancellationToken);

            return personagens?.data?.results?.Select(personagem => (PersonagensViewModel)personagem);
        }

        public async Task<IEnumerable<PersonagemViewModel>> ObterPersonagem(int id, CancellationToken cancellationToken)
        {
            var personagem = await repositorioMarvel.ObterPersonagem(id, cancellationToken);

            return personagem?.data?.results?.Select(personagem => (PersonagemViewModel)personagem);
        }

        public async Task<IEnumerable<QuadrinhoViewModel>> ObterQuadrinhos(int id, CancellationToken cancellationToken)
        {
            var quadrinhos = await repositorioMarvel.ObterQuadrinhos(id, cancellationToken);

            return quadrinhos?.data?.results?.Select(quadrinho => (QuadrinhoViewModel)quadrinho);

        }

        public async Task<IEnumerable<EventoViewModel>> ObterEventos(int id, CancellationToken cancellationToken)
        {
            var eventos = await repositorioMarvel.ObterEventos(id, cancellationToken);

            return eventos?.data?.results?.Select(evento => (EventoViewModel)evento);
        }

        public async Task<IEnumerable<SerieViewModel>> ObterSeries(int id, CancellationToken cancellationToken)
        {
            var series = await repositorioMarvel.ObterSeries(id, cancellationToken);

            return series?.data?.results?.Select(series => (SerieViewModel)series);

        }

        public async Task<IEnumerable<HistoriaViewModel>> ObterHistorias(int id, CancellationToken cancellationToken)
        {
            var historias = await repositorioMarvel.ObterHistorias(id, cancellationToken);

            return historias?.data?.results?.Select(historia => (HistoriaViewModel)historia);
        }
    }
}
