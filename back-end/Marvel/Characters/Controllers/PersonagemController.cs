using Dominio.Interface.Aplicacao;
using Dominio.Model;
using Dominio.Model.Eventos;
using Dominio.Model.Historias;
using Dominio.Model.Personagem;
using Dominio.Model.Personagens;
using Dominio.Model.Quadrinhos;
using Dominio.Model.SeriesX;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class PersonagemController : ControllerBase
    {
        private readonly IServicoAplicacaoMarvel servicoAplicacaoMarvel;

        public PersonagemController(IServicoAplicacaoMarvel servicoAplicacaoMarvel)
        {
            this.servicoAplicacaoMarvel = servicoAplicacaoMarvel;
        }

        [HttpGet("obterpersonagens")]
        public async Task<ActionResult<Personagens>> ObterPersonagens(CancellationToken cancellationToken = default)
        {
            var result = await this.servicoAplicacaoMarvel.ObterPersonagens(cancellationToken);

             return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}")]
        public async Task<ActionResult<Personagem>> ObterPersonagem(int id, CancellationToken cancellationToken = default)
        {
            var result = await this.servicoAplicacaoMarvel.ObterPersonagem(id, cancellationToken);

            return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}/quadrinhos")]
        public async Task<ActionResult<Quadrinhos>> ObterQuadrinhos(int id, CancellationToken cancellationToken = default)
        {
            var result = await this.servicoAplicacaoMarvel.ObterQuadrinhos(id, cancellationToken);

            return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}/eventos")]
        public async Task<ActionResult<Eventos>> ObterEventos(int id, CancellationToken cancellationToken = default)
        {
            var result = await this.servicoAplicacaoMarvel.ObterEventos(id, cancellationToken);

            return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}/series")]
        public async Task<ActionResult<Series>> ObterSeries(int id, CancellationToken cancellationToken = default)
        {
            var result = await this.servicoAplicacaoMarvel.ObterSeries(id, cancellationToken);

            return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}/historias")]
        public async Task<ActionResult<Historias>> ObterHistorias(int id, CancellationToken cancellationToken = default)
        {
            var result = await this.servicoAplicacaoMarvel.ObterHistorias(id, cancellationToken);

            return Ok(result);
        }
    }
}
