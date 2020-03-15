using Dominio.Interface.Aplicacao;
using Dominio.Interface.Infra;
using Dominio.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class ServicoAplicacaoMarvelDB : IServicoAplicacaoMarvelDB
    {
        private readonly IRepositorioMarvelDB repositorioMarvelDB;

        public ServicoAplicacaoMarvelDB(IRepositorioMarvelDB repositorioMarvel)
        {
            this.repositorioMarvelDB = repositorioMarvel;
        }

        public async Task<IEnumerable<PersonagensViewModel>> ObterPersonagens()
        {
            return await repositorioMarvelDB.ObterPersonagens();
        }

        public async Task<PersonagemViewModel> ObterPersonagem(int id)
        {
            return await repositorioMarvelDB.ObterPersonagem(id);
        }

        public async Task<IEnumerable<QuadrinhoViewModel>> ObterQuadrinhos(int idPersonagem)
        {
            return await repositorioMarvelDB.ObterQuadrinhos(idPersonagem);
        }

        public async Task<IEnumerable<EventoViewModel>> ObterEventos(int idPersonagem)
        {
            return await repositorioMarvelDB.ObterEventos(idPersonagem);
        }

        public async Task<IEnumerable<SerieViewModel>> ObterSeries(int idPersonagem)
        {
            return await repositorioMarvelDB.ObterSeries(idPersonagem);
        }

        public async Task<IEnumerable<HistoriaViewModel>> ObterHistorias(int idPersonagem)
        {
            return await repositorioMarvelDB.ObterHistorias(idPersonagem);
        }
    }
}
