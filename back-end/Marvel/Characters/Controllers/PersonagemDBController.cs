using Dominio.Interface.Aplicacao;
using Dominio.ViewModel;
using Infra.Comum;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class PersonagemDBController : ControllerBase
    {
        private readonly IServicoAplicacaoMarvelDB servicoAplicacaoMarvelDB;

        public PersonagemDBController(IServicoAplicacaoMarvelDB servicoAplicacaoMarvelDB)
        {
            this.servicoAplicacaoMarvelDB = servicoAplicacaoMarvelDB;
        }

        [HttpGet("obterpersonagens")]
        public async Task<ActionResult<IEnumerable<PersonagemViewModel>>> ObterPersonagens()
        {
            var result = await this.servicoAplicacaoMarvelDB.ObterPersonagens();

            return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}")]
        public async Task<ActionResult<IEnumerable<PersonagemViewModel>>> ObterPersonagem(int id)
        {
            try
            {
                var result = await this.servicoAplicacaoMarvelDB.ObterPersonagem(id);

                return Ok(result);
            }
            catch (MarvelException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound();
            }
        }

        [HttpGet("obterpersonagem/{id}/quadrinhos")]
        public async Task<ActionResult<IEnumerable<QuadrinhoViewModel>>> ObterQuadrinhos(int id)
        {
            var result = await this.servicoAplicacaoMarvelDB.ObterQuadrinhos(id);

            return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}/eventos")]
        public async Task<ActionResult<IEnumerable<EventoViewModel>>> ObterEventos(int id)
        {
            var result = await this.servicoAplicacaoMarvelDB.ObterEventos(id);

            return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}/series")]
        public async Task<ActionResult<IEnumerable<SerieViewModel>>> ObterSeries(int id)
        {
            var result = await this.servicoAplicacaoMarvelDB.ObterSeries(id);

            return Ok(result);
        }

        [HttpGet("obterpersonagem/{id}/historias")]
        public async Task<ActionResult<IEnumerable<HistoriaViewModel>>> ObterHistorias(int id)
        {
            var result = await this.servicoAplicacaoMarvelDB.ObterHistorias(id);

            return Ok(result);
        }
    }
}
