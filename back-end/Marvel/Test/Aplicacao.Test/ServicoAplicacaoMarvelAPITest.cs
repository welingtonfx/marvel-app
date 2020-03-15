using Aplicacao;
using AutoFixture;
using Dominio.Interface.Infra;
using Dominio.Model.Eventos;
using Dominio.Model.Historias;
using Dominio.Model.Personagem;
using Dominio.Model.Personagens;
using Dominio.Model.Quadrinhos;
using Dominio.Model.Series;
using Dominio.ViewModel;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Test.Aplicacao.Test
{

    public class ServicoAplicacaoMarvelAPITest
    {
        private readonly Fixture _fixture;
        private readonly Mock<IRepositorioMarvelAPI> _repositorioMarvelMock;
        private readonly ServicoAplicacaoMarvelAPI _servicoAplicacaoMarvel;

        public ServicoAplicacaoMarvelAPITest()
        {
            _fixture = new Fixture();
            _repositorioMarvelMock = new Mock<IRepositorioMarvelAPI>();
            _servicoAplicacaoMarvel = new ServicoAplicacaoMarvelAPI(_repositorioMarvelMock.Object);
        }

        // Personagens

        [Fact]
        public async Task DeveRetornarListaComTodosOsPersonagens()
        {
            var personagens = _fixture.Create<Personagens>();

            _repositorioMarvelMock.Setup(f => f.ObterPersonagens(It.IsAny<CancellationToken>())).ReturnsAsync(personagens);

            var result = await _servicoAplicacaoMarvel.ObterPersonagens(It.IsAny<CancellationToken>());

            Assert.IsType<List<PersonagensViewModel>>(result.ToList());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarNuloQuandoNaoHouverPersonagens()
        {
            _repositorioMarvelMock.Setup(f => f.ObterPersonagens(It.IsAny<CancellationToken>()));

            var result = await _servicoAplicacaoMarvel.ObterPersonagens(It.IsAny<CancellationToken>());

            Assert.Null(result);
        }

        // Personagem

        [Fact]
        public async Task DeveRetornarListaDePersonagemQuandoExistir()
        {
            var personagem = _fixture.Create<Personagem>();

            _repositorioMarvelMock.Setup(f => f.ObterPersonagem(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(personagem);

            var result = await _servicoAplicacaoMarvel.ObterPersonagem(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<List<PersonagemViewModel>>(result.ToList());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarNuloQuandoNaoExistirPersonagem()
        {
            _repositorioMarvelMock.Setup(f => f.ObterPersonagem(It.IsAny<int>(), It.IsAny<CancellationToken>()));

            var result = await _servicoAplicacaoMarvel.ObterPersonagem(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.Null(result);
        }

        // Eventos
        [Fact]
        public async Task DeveRetornarListaDeEventosQuandoExistir()
        {
            var eventos = _fixture.Create<Eventos>();

            _repositorioMarvelMock.Setup(f => f.ObterEventos(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(eventos);

            var result = await _servicoAplicacaoMarvel.ObterEventos(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<List<EventoViewModel>>(result.ToList());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarNuloQuandoNaoExistirEvento()
        {
            _repositorioMarvelMock.Setup(f => f.ObterEventos(It.IsAny<int>(), It.IsAny<CancellationToken>()));

            var result = await _servicoAplicacaoMarvel.ObterEventos(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.Null(result);
        }

        // Quadrinhos
        [Fact]
        public async Task DeveRetornarListaDeQuadrinhosQuandoExistir()
        {
            var quadrinhos = _fixture.Create<Quadrinhos>();

            _repositorioMarvelMock.Setup(f => f.ObterQuadrinhos(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(quadrinhos);

            var result = await _servicoAplicacaoMarvel.ObterQuadrinhos(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<List<QuadrinhoViewModel>>(result.ToList());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarNuloQuandoNaoExistirQuadrinho()
        {
            _repositorioMarvelMock.Setup(f => f.ObterQuadrinhos(It.IsAny<int>(), It.IsAny<CancellationToken>()));

            var result = await _servicoAplicacaoMarvel.ObterQuadrinhos(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.Null(result);
        }

        // Histórias
        [Fact]
        public async Task DeveRetornarListaDeHistoriasQuandoExistir()
        {
            var historias = _fixture.Create<Historias>();

            _repositorioMarvelMock.Setup(f => f.ObterHistorias(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(historias);

            var result = await _servicoAplicacaoMarvel.ObterHistorias(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<List<HistoriaViewModel>>(result.ToList());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarNuloQuandoNaoExistirHistoria()
        {
            _repositorioMarvelMock.Setup(f => f.ObterHistorias(It.IsAny<int>(), It.IsAny<CancellationToken>()));

            var result = await _servicoAplicacaoMarvel.ObterHistorias(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.Null(result);
        }

        // Séries
        [Fact]
        public async Task DeveRetornarListaDeSeriesQuandoExistir()
        {
            var historias = _fixture.Create<Series>();

            _repositorioMarvelMock.Setup(f => f.ObterSeries(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(historias);

            var result = await _servicoAplicacaoMarvel.ObterSeries(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<List<SerieViewModel>>(result.ToList());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarNuloQuandoNaoExistirSerie()
        {
            _repositorioMarvelMock.Setup(f => f.ObterSeries(It.IsAny<int>(), It.IsAny<CancellationToken>()));

            var result = await _servicoAplicacaoMarvel.ObterSeries(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.Null(result);
        }
    }
}
