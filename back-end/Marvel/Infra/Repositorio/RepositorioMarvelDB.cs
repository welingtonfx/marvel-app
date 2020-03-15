using Dapper;
using Dominio.Interface.Infra;
using Dominio.ViewModel;
using Npgsql;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioMarvelDB : IRepositorioMarvelDB
    {
        public RepositorioMarvelDB()
        {

        }

        public const string connectionString = @"Server=localhost;Port=5432;Database=marvel;User Id=postgres;Password=wellfx200;";

        public async Task<IEnumerable<PersonagensViewModel>> ObterPersonagens()
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                var sql = @"SELECT * FROM public.personagem";
                return await conexao.QueryAsync<PersonagensViewModel>(sql);
            }
        }

        public async Task<PersonagemViewModel> ObterPersonagem(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                var sql = @"SELECT * FROM public.personagem WHERE id = @Id";
                return await conexao.QueryFirstOrDefaultAsync<PersonagemViewModel>(sql, new { id });
            }
        }

        public async Task<IEnumerable<QuadrinhoViewModel>> ObterQuadrinhos(int idPersonagem)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                var sql = @"SELECT * FROM public.quadrinho WHERE idcharacter = @IdPersonagem";
                return await conexao.QueryAsync<QuadrinhoViewModel>(sql, new { idPersonagem });
            }
        }

        public async Task<IEnumerable<EventoViewModel>> ObterEventos(int idPersonagem)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                var sql = @"SELECT * FROM public.evento WHERE idcharacter = @IdPersonagem";
                return await conexao.QueryAsync<EventoViewModel>(sql, new { idPersonagem });
            }
        }

        public async Task<IEnumerable<SerieViewModel>> ObterSeries(int idPersonagem)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                var sql = @"SELECT * FROM public.serie WHERE idcharacter = @IdPersonagem";
                return await conexao.QueryAsync<SerieViewModel>(sql, new { idPersonagem });
            }
        }

        public async Task<IEnumerable<HistoriaViewModel>> ObterHistorias(int idPersonagem)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(connectionString))
            {
                var sql = @"SELECT * FROM public.historia WHERE idcharacter = @IdPersonagem";
                return await conexao.QueryAsync<HistoriaViewModel>(sql, new { idPersonagem });
            }
        }
    }
}
