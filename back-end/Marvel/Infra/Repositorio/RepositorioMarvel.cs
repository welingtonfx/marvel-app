using Dominio.Interface.Infra;
using Dominio.Model;
using Dominio.Model.Eventos;
using Dominio.Model.Historias;
using Dominio.Model.Personagem;
using Dominio.Model.Personagens;
using Dominio.Model.Quadrinhos;
using Dominio.Model.SeriesX;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioMarvel : IRepositorioMarvel
    {
        private const string ts = "1";
        private const string publicKey = "1fa6a5c33c0ed190b4106f37f05cdb4d";
        private const string privateKey = "c6fd9a77017ff36b54c2be7e2f51ef1599bcb86a";
        private const string baseURL = "https://gateway.marvel.com:443/v1/public";
        private const string hash = "ff76c9f3f4bc2c74b3356187040ad377";
        private const string charactersURL = "/characters";

        public async Task<Personagens> ObterPersonagens(CancellationToken cancellationToken)
        {
            var client = new RestClient(baseURL);

            var request = new RestRequest(charactersURL, Method.GET, DataFormat.Json);

            request.AddQueryParameter("apikey", publicKey);
            request.AddQueryParameter("ts", ts);
            request.AddQueryParameter("hash", hash);

            var result = await client.ExecuteAsync(request, cancellationToken);

            var resultado = JsonConvert.DeserializeObject<Personagens>(result.Content);

            if (result.IsSuccessful)
                return resultado;
            else
                return null;

            //return result.IsSuccessful? JsonConvert.DeserializeObject<List<Ammenities>>(result.Content) : null;
        }

        public async Task<Personagem> ObterPersonagem(int id, CancellationToken cancellationToken)
        {
            var client = new RestClient(baseURL);

            var request = new RestRequest($"{charactersURL}/{id}", Method.GET, DataFormat.Json);

            request.AddQueryParameter("apikey", publicKey);
            request.AddQueryParameter("ts", ts);
            request.AddQueryParameter("hash", hash);

            var result = await client.ExecuteAsync(request, cancellationToken);

            var resultado = JsonConvert.DeserializeObject<Personagem>(result.Content);

            if (result.IsSuccessful)
                return resultado;
            else
                return null;
        }

        public async Task<Quadrinhos> ObterQuadrinhos(int id, CancellationToken cancellationToken)
        {
            var client = new RestClient(baseURL);

            var request = new RestRequest($"{charactersURL}/{id}/comics", Method.GET, DataFormat.Json);

            request.AddQueryParameter("apikey", publicKey);
            request.AddQueryParameter("ts", ts);
            request.AddQueryParameter("hash", hash);

            var result = await client.ExecuteAsync(request, cancellationToken);

            var resultado = JsonConvert.DeserializeObject<Quadrinhos>(result.Content);

            if (result.IsSuccessful)
                return resultado;
            else
                return null;
        }

        public async Task<Eventos> ObterEventos(int id, CancellationToken cancellationToken)
        {
            var client = new RestClient(baseURL);

            var request = new RestRequest($"{charactersURL}/{id}/events", Method.GET, DataFormat.Json);

            request.AddQueryParameter("apikey", publicKey);
            request.AddQueryParameter("ts", ts);
            request.AddQueryParameter("hash", hash);

            var result = await client.ExecuteAsync(request, cancellationToken);

            var resultado = JsonConvert.DeserializeObject<Eventos>(result.Content);

            if (result.IsSuccessful)
                return resultado;
            else
                return null;
        }

        public async Task<Series> ObterSeries(int id, CancellationToken cancellationToken)
        {
            var client = new RestClient(baseURL);

            var request = new RestRequest($"{charactersURL}/{id}/series", Method.GET, DataFormat.Json);

            request.AddQueryParameter("apikey", publicKey);
            request.AddQueryParameter("ts", ts);
            request.AddQueryParameter("hash", hash);

            var result = await client.ExecuteAsync(request, cancellationToken);

            var resultado = JsonConvert.DeserializeObject<Series>(result.Content);

            if (result.IsSuccessful)
                return resultado;
            else
                return null;
        }

        public async Task<Historias> ObterHistorias(int id, CancellationToken cancellationToken)
        {
            var client = new RestClient(baseURL);

            var request = new RestRequest($"{charactersURL}/{id}/stories", Method.GET, DataFormat.Json);

            request.AddQueryParameter("apikey", publicKey);
            request.AddQueryParameter("ts", ts);
            request.AddQueryParameter("hash", hash);

            var result = await client.ExecuteAsync(request, cancellationToken);

            var resultado = JsonConvert.DeserializeObject<Historias>(result.Content);

            if (result.IsSuccessful)
                return resultado;
            else
                return null;
        }
    }
}
