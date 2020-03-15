using Dominio.Interface.Aplicacao;
using Dominio.ViewModel;
using Infra.Comum;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class PersonagemAPIController : ControllerBase
    {
        private readonly IServicoAplicacaoMarvelAPI servicoAplicacaoMarvel;

        public PersonagemAPIController(IServicoAplicacaoMarvelAPI servicoAplicacaoMarvel)
        {
            this.servicoAplicacaoMarvel = servicoAplicacaoMarvel;
        }

        [HttpGet("obterpersonagens")]
        public async Task<ActionResult<IEnumerable<PersonagensViewModel>>> ObterPersonagens(CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await this.servicoAplicacaoMarvel.ObterPersonagens(cancellationToken);

                return Ok(result);
            }
            catch (MarvelException ex) when (ex.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                return Conflict(new { Erro = ex.StatusMessage });
            }
        }

        [HttpGet("obterpersonagem/{id}")]
        public async Task<ActionResult<IEnumerable<PersonagemViewModel>>> ObterPersonagem(int id, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await this.servicoAplicacaoMarvel.ObterPersonagem(id, cancellationToken);

                return Ok(result);
            }
            catch (MarvelException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound();
            }
        }

        [HttpGet("obterpersonagem/{id}/quadrinhos")]
        public async Task<ActionResult<IEnumerable<QuadrinhoViewModel>>> ObterQuadrinhos(int id, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await this.servicoAplicacaoMarvel.ObterQuadrinhos(id, cancellationToken);

                return Ok(result);
            }
            catch (MarvelException ex) when (ex.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                return Conflict(new { Erro = ex.StatusMessage });
            }
        }

        [HttpGet("obterpersonagem/{id}/eventos")]
        public async Task<ActionResult<IEnumerable<EventoViewModel>>> ObterEventos(int id, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await this.servicoAplicacaoMarvel.ObterEventos(id, cancellationToken);

                return Ok(result);
            }
            catch (MarvelException ex) when (ex.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                return Conflict(new { Erro = ex.StatusMessage });
            }
        }

        [HttpGet("obterpersonagem/{id}/series")]
        public async Task<ActionResult<IEnumerable<SerieViewModel>>> ObterSeries(int id, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await this.servicoAplicacaoMarvel.ObterSeries(id, cancellationToken);

                return Ok(result);
            }
            catch (MarvelException ex) when (ex.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                return Conflict(new { Erro = ex.StatusMessage });
            }
        }

        [HttpGet("obterpersonagem/{id}/historias")]
        public async Task<ActionResult<IEnumerable<HistoriaViewModel>>> ObterHistorias(int id, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await this.servicoAplicacaoMarvel.ObterHistorias(id, cancellationToken);

                return Ok(result);
            }
            catch (MarvelException ex) when (ex.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                return Conflict(new { Erro = ex.StatusMessage });
            }
        }
    }
}
