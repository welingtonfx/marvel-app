using Dapper;
using Dominio.Interface.Infra;
using Dominio.Model;
using Dominio.ViewModel;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioMarvelDB : IRepositorioMarvelDB
    {
        private readonly IConfiguration configuration;
        private string ConnectionString { get; set; }

        public RepositorioMarvelDB(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.ConnectionString = configuration.GetSection("Marvel").GetSection("DatabaseConnection").GetSection("ConnectionString").Value;
        }

        public async Task<IEnumerable<PersonagemDB>> ObterPersonagens()
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(ConnectionString))
            {
                var sql = @"SELECT * FROM public.personagem";
                return await conexao.QueryAsync<PersonagemDB>(sql);
            }
        }

        public async Task<PersonagemDB> ObterPersonagem(int id)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(ConnectionString))
            {
                var sql = @"SELECT * FROM public.personagem WHERE id = @Id";
                return await conexao.QueryFirstOrDefaultAsync<PersonagemDB>(sql, new { id });
            }
        }

        public async Task<IEnumerable<QuadrinhoDB>> ObterQuadrinhos(int idPersonagem)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(ConnectionString))
            {
                var sql = @"SELECT * FROM public.quadrinho WHERE idcharacter = @IdPersonagem";
                return await conexao.QueryAsync<QuadrinhoDB>(sql, new { idPersonagem });
            }
        }

        public async Task<IEnumerable<EventoDB>> ObterEventos(int idPersonagem)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(ConnectionString))
            {
                var sql = @"SELECT * FROM public.evento WHERE idcharacter = @IdPersonagem";
                return await conexao.QueryAsync<EventoDB>(sql, new { idPersonagem });
            }
        }

        public async Task<IEnumerable<SerieDB>> ObterSeries(int idPersonagem)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(ConnectionString))
            {
                var sql = @"SELECT * FROM public.serie WHERE idcharacter = @IdPersonagem";
                return await conexao.QueryAsync<SerieDB>(sql, new { idPersonagem });
            }
        }

        public async Task<IEnumerable<HistoriaDB>> ObterHistorias(int idPersonagem)
        {
            using (NpgsqlConnection conexao = new NpgsqlConnection(ConnectionString))
            {
                var sql = @"SELECT * FROM public.historia WHERE idcharacter = @IdPersonagem";
                return await conexao.QueryAsync<HistoriaDB>(sql, new { idPersonagem });
            }
        }
    }
}
