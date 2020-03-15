using Dominio.Interface.Aplicacao;
using Dominio.ViewModel;
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
            var result = await this.servicoAplicacaoMarvel.ObterPersonagens(cancellationToken);

             return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}")]
        public async Task<ActionResult<IEnumerable<PersonagemViewModel>>> ObterPersonagem(int id, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await this.servicoAplicacaoMarvel.ObterPersonagem(id, cancellationToken);

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                if (ex.Message == "404")
                    return NotFound();

                return null;
            }
        }

        [HttpGet("obterpersonagem/{id}/quadrinhos")]
        public async Task<ActionResult<IEnumerable<QuadrinhoViewModel>>> ObterQuadrinhos(int id, CancellationToken cancellationToken = default)
        {
            var result = await this.servicoAplicacaoMarvel.ObterQuadrinhos(id, cancellationToken);

            return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}/eventos")]
        public async Task<ActionResult<IEnumerable<EventoViewModel>>> ObterEventos(int id, CancellationToken cancellationToken = default)
        {
            var result = await this.servicoAplicacaoMarvel.ObterEventos(id, cancellationToken);

            return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}/series")]
        public async Task<ActionResult<IEnumerable<SerieViewModel>>> ObterSeries(int id, CancellationToken cancellationToken = default)
        {
            var result = await this.servicoAplicacaoMarvel.ObterSeries(id, cancellationToken);

            return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}/historias")]
        public async Task<ActionResult<IEnumerable<HistoriaViewModel>>> ObterHistorias(int id, CancellationToken cancellationToken = default)
        {
            var result = await this.servicoAplicacaoMarvel.ObterHistorias(id, cancellationToken);

            return Ok(result);
        }
    }
}
