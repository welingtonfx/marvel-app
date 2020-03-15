using Dominio.Interface;
using Dominio.Interface.Infra;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace Infra.Comum
{
    public class MarvelAPIConnector : IMarvelAPIConnector
    {
        private const string baseURL = "https://gateway.marvel.com:443/v1/public";

        private readonly IMarvelHasher marvelHasher;
        public MarvelAPIConnector(IMarvelHasher marvelHasher)
        {
            this.marvelHasher = marvelHasher;
        }

        public async Task<IRestResponse> ObterGetResponse(string url, CancellationToken cancellationToken)
        {
            var client = new RestClient(baseURL);

            var request = new RestRequest($"{baseURL}/{url}", Method.GET, DataFormat.Json);
            AdicionarParametrosAutencicacao(request);

            return await client.ExecuteAsync(request, cancellationToken);
        }

        private void AdicionarParametrosAutencicacao(RestRequest restRequest)
        {
            restRequest.AddQueryParameter("apikey", marvelHasher.PublicKey);
            restRequest.AddQueryParameter("ts", marvelHasher.TimeStamp);
            restRequest.AddQueryParameter("hash", marvelHasher.ObterHash());
        }
    }
}
