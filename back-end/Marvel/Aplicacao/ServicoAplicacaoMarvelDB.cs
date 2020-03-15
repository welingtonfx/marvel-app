using Dominio.Interface.Aplicacao;
using Dominio.Interface.Infra;
using Dominio.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Aplicacao
{
    public class ServicoAplicacaoMarvelDB : IServicoAplicacaoMarvelDB
    {
        private readonly IRepositorioMarvelDB repositorioMarvelDB;

        public ServicoAplicacaoMarvelDB(IRepositorioMarvelDB repositorioMarvel)
        {
            this.repositorioMarvelDB = repositorioMarvel;
        }

        public async Task<IEnumerable<PersonagemViewModel>> ObterPersonagens()
        {
            var resultado = await repositorioMarvelDB.ObterPersonagens();

            return resultado.Select(personagem => (PersonagemViewModel)personagem);
        }

        public async Task<PersonagemViewModel> ObterPersonagem(int id)
        {
            var resultado = await repositorioMarvelDB.ObterPersonagem(id);
            return resultado != null ? (PersonagemViewModel)resultado : null;
        }

        public async Task<IEnumerable<QuadrinhoViewModel>> ObterQuadrinhos(int idPersonagem)
        {
            var resultado = await repositorioMarvelDB.ObterQuadrinhos(idPersonagem);
            return resultado.Select(quadrinho => (QuadrinhoViewModel)quadrinho);
        }

        public async Task<IEnumerable<EventoViewModel>> ObterEventos(int idPersonagem)
        {
            var resultado = await repositorioMarvelDB.ObterEventos(idPersonagem);
            return resultado.Select(evento => (EventoViewModel)evento);
        }

        public async Task<IEnumerable<SerieViewModel>> ObterSeries(int idPersonagem)
        {
            var resultado = await repositorioMarvelDB.ObterSeries(idPersonagem);
            return resultado.Select(serie => (SerieViewModel)serie);
        }

        public async Task<IEnumerable<HistoriaViewModel>> ObterHistorias(int idPersonagem)
        {
            var resultado = await repositorioMarvelDB.ObterHistorias(idPersonagem);
            return resultado.Select(historia => (HistoriaViewModel)historia);
        }
    }
}
