using Dominio.Interface;
using Dominio.Interface.Infra;
using Dominio.Model.Eventos;
using Dominio.Model.Historias;
using Dominio.Model.Personagem;
using Dominio.Model.Personagens;
using Dominio.Model.Quadrinhos;
using Dominio.Model.Series;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioMarvel : IRepositorioMarvel
    {
        private const string charactersURL = "/characters";

        private readonly IMarvelAPIConnector marvelAPIConnector;

        public RepositorioMarvel(IMarvelAPIConnector marvelAPIConnector)
        {
            this.marvelAPIConnector = marvelAPIConnector;
        }

        public async Task<Personagens> ObterPersonagens(CancellationToken cancellationToken)
        {
            var resultado = await marvelAPIConnector.ObterGetResponse(charactersURL, cancellationToken);

            return resultado.IsSuccessful ? JsonConvert.DeserializeObject<Personagens>(resultado.Content) : null;
        }

        public async Task<Personagem> ObterPersonagem(int id, CancellationToken cancellationToken)
        {
            var resultado = await marvelAPIConnector.ObterGetResponse($"{charactersURL}/{id}", cancellationToken);

            return resultado.IsSuccessful ? JsonConvert.DeserializeObject<Personagem>(resultado.Content) : null;

        }

        public async Task<Quadrinhos> ObterQuadrinhos(int id, CancellationToken cancellationToken)
        {
            var resultado = await marvelAPIConnector.ObterGetResponse($"{charactersURL}/{id}/comics", cancellationToken);

            return resultado.IsSuccessful ? JsonConvert.DeserializeObject<Quadrinhos>(resultado.Content) : null;
        }

        public async Task<Eventos> ObterEventos(int id, CancellationToken cancellationToken)
        {
            var resultado = await marvelAPIConnector.ObterGetResponse($"{charactersURL}/{id}/events", cancellationToken);

            return resultado.IsSuccessful ? JsonConvert.DeserializeObject<Eventos>(resultado.Content) : null;
        }

        public async Task<Series> ObterSeries(int id, CancellationToken cancellationToken)
        {
            var resultado = await marvelAPIConnector.ObterGetResponse($"{charactersURL}/{id}/series", cancellationToken);

            return resultado.IsSuccessful ? JsonConvert.DeserializeObject<Series>(resultado.Content) : null;
        }

        public async Task<Historias> ObterHistorias(int id, CancellationToken cancellationToken)
        {
            var resultado = await marvelAPIConnector.ObterGetResponse($"{charactersURL}/{id}/stories", cancellationToken);

            return resultado.IsSuccessful ? JsonConvert.DeserializeObject<Historias>(resultado.Content) : null;
        }
    }
}
