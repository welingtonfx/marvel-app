using API.Controllers;
using AutoFixture;
using Dominio.Interface.Aplicacao;
using Dominio.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Test.API.Test
{
    public class PersonagemAPIControllerTest
    {
        private PersonagemAPIController personagemController;
        private readonly Mock<IServicoAplicacaoMarvelAPI> servicoAplicacaoMarvel;
        private readonly Fixture _fixture;
        public PersonagemAPIControllerTest()
        {
            _fixture = new Fixture();
            servicoAplicacaoMarvel = new Mock<IServicoAplicacaoMarvelAPI>();
            personagemController = new PersonagemAPIController(servicoAplicacaoMarvel.Object);
        }

        [Fact]
        public async Task RotaPersonagensDeveRetornarTiposCorretos()
        {
            var personagens = _fixture.CreateMany<PersonagensViewModel>();

            servicoAplicacaoMarvel.Setup(p => p.ObterPersonagens(It.IsAny<CancellationToken>())).ReturnsAsync(personagens);

            var retorno = await personagemController.ObterPersonagens(It.IsAny<CancellationToken>());

            Assert.IsType<ActionResult<IEnumerable<PersonagensViewModel>>>(retorno);
            Assert.IsType<OkObjectResult>(retorno.Result);
        }

        [Fact]
        public async Task RotaPersonagemDeveRetornarTiposCorretos()
        {
            var personagem = _fixture.CreateMany<PersonagemViewModel>();

            servicoAplicacaoMarvel.Setup(p => p.ObterPersonagem(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(personagem);

            var retorno = await personagemController.ObterPersonagem(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<ActionResult<IEnumerable<PersonagemViewModel>>>(retorno);
            Assert.IsType<OkObjectResult>(retorno.Result);
        }

        [Fact]
        public async Task RotaEventosDeveRetornarTiposCorretos()
        {
            var eventos = _fixture.CreateMany<EventoViewModel>();

            servicoAplicacaoMarvel.Setup(p => p.ObterEventos(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(eventos);

            var retorno = await personagemController.ObterEventos(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<ActionResult<IEnumerable<EventoViewModel>>>(retorno);
            Assert.IsType<OkObjectResult>(retorno.Result);
        }

        [Fact]
        public async Task RotaQuadrinhosDeveRetornarTiposCorretos()
        {
            var eventos = _fixture.CreateMany<QuadrinhoViewModel>();

            servicoAplicacaoMarvel.Setup(p => p.ObterQuadrinhos(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(eventos);

            var retorno = await personagemController.ObterQuadrinhos(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<ActionResult<IEnumerable<QuadrinhoViewModel>>>(retorno);
            Assert.IsType<OkObjectResult>(retorno.Result);
        }

        [Fact]
        public async Task RotaHistoriasDeveRetornarTiposCorretos()
        {
            var eventos = _fixture.CreateMany<HistoriaViewModel>();

            servicoAplicacaoMarvel.Setup(p => p.ObterHistorias(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(eventos);

            var retorno = await personagemController.ObterHistorias(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<ActionResult<IEnumerable<HistoriaViewModel>>>(retorno);
            Assert.IsType<OkObjectResult>(retorno.Result);
        }

        [Fact]
        public async Task RotaSeriesDeveRetornarTiposCorretos()
        {
            var eventos = _fixture.CreateMany<SerieViewModel>();

            servicoAplicacaoMarvel.Setup(p => p.ObterSeries(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(eventos);

            var retorno = await personagemController.ObterSeries(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<ActionResult<IEnumerable<SerieViewModel>>>(retorno);
            Assert.IsType<OkObjectResult>(retorno.Result);
        }
    }
}
