using Aplicacao;
using AutoFixture;
using Dominio.Interface.Infra;
using Dominio.ViewModel;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Test.Aplicacao.Test
{
    public class ServicoAplicacaoMarvelDBTest
    {
        private readonly Fixture _fixture;
        private readonly Mock<IRepositorioMarvelDB> _repositorioMarvelMock;
        private readonly ServicoAplicacaoMarvelDB _servicoAplicacaoMarvel;

        public ServicoAplicacaoMarvelDBTest()
        {
            _fixture = new Fixture();
            _repositorioMarvelMock = new Mock<IRepositorioMarvelDB>();
            _servicoAplicacaoMarvel = new ServicoAplicacaoMarvelDB(_repositorioMarvelMock.Object);
        }

        // Personagens

        [Fact]
        public async Task DeveRetornarListaComTodosOsPersonagens()
        {
            var personagens = _fixture.CreateMany<PersonagensViewModel>();

            _repositorioMarvelMock.Setup(f => f.ObterPersonagens()).ReturnsAsync(personagens);

            var result = await _servicoAplicacaoMarvel.ObterPersonagens();

            Assert.IsType<List<PersonagensViewModel>>(result.ToList());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarListaVaziaQuandoNaoHouverPersonagens()
        {
            _repositorioMarvelMock.Setup(f => f.ObterPersonagens());

            var result = await _servicoAplicacaoMarvel.ObterPersonagens();

            Assert.NotNull(result);
            Assert.IsType<List<PersonagensViewModel>>(result.ToList());
            Assert.Empty(result);
        }

        // Personagem

        [Fact]
        public async Task DeveRetornarListaDePersonagemQuandoExistir()
        {
            var personagem = _fixture.Create<PersonagemViewModel>();

            _repositorioMarvelMock.Setup(f => f.ObterPersonagem(It.IsAny<int>())).ReturnsAsync(personagem);

            var result = await _servicoAplicacaoMarvel.ObterPersonagem(It.IsAny<int>());

            Assert.IsType<PersonagemViewModel>(result);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarNuloQuandoNaoExistirPersonagem()
        {
            _repositorioMarvelMock.Setup(f => f.ObterPersonagem(It.IsAny<int>()));

            var result = await _servicoAplicacaoMarvel.ObterPersonagem(It.IsAny<int>());

            Assert.Null(result);
        }

        // Eventos
        [Fact]
        public async Task DeveRetornarListaDeEventosQuandoExistir()
        {
            var eventos = _fixture.CreateMany<EventoViewModel>();

            _repositorioMarvelMock.Setup(f => f.ObterEventos(It.IsAny<int>())).ReturnsAsync(eventos);

            var result = await _servicoAplicacaoMarvel.ObterEventos(It.IsAny<int>());

            Assert.IsType<List<EventoViewModel>>(result.ToList());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarListaVaziaQuandoNaoExistirEvento()
        {
            _repositorioMarvelMock.Setup(f => f.ObterEventos(It.IsAny<int>()));

            var result = await _servicoAplicacaoMarvel.ObterEventos(It.IsAny<int>());

            Assert.NotNull(result);
            Assert.IsType<List<EventoViewModel>>(result.ToList());
            Assert.Empty(result);
        }

        // Quadrinhos
        [Fact]
        public async Task DeveRetornarListaDeQuadrinhosQuandoExistir()
        {
            var quadrinhos = _fixture.CreateMany<QuadrinhoViewModel>();

            _repositorioMarvelMock.Setup(f => f.ObterQuadrinhos(It.IsAny<int>())).ReturnsAsync(quadrinhos);

            var result = await _servicoAplicacaoMarvel.ObterQuadrinhos(It.IsAny<int>());

            Assert.IsType<List<QuadrinhoViewModel>>(result.ToList());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarListaVaziaQuandoNaoExistirQuadrinho()
        {
            _repositorioMarvelMock.Setup(f => f.ObterQuadrinhos(It.IsAny<int>()));

            var result = await _servicoAplicacaoMarvel.ObterQuadrinhos(It.IsAny<int>());

            Assert.NotNull(result);
            Assert.IsType<List<QuadrinhoViewModel>>(result.ToList());
            Assert.Empty(result);
        }

        // Histórias
        [Fact]
        public async Task DeveRetornarListaDeHistoriasQuandoExistir()
        {
            var historias = _fixture.CreateMany<HistoriaViewModel>();

            _repositorioMarvelMock.Setup(f => f.ObterHistorias(It.IsAny<int>())).ReturnsAsync(historias);

            var result = await _servicoAplicacaoMarvel.ObterHistorias(It.IsAny<int>());

            Assert.IsType<List<HistoriaViewModel>>(result.ToList());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarListaVaziaQuandoNaoExistirHistoria()
        {
            _repositorioMarvelMock.Setup(f => f.ObterHistorias(It.IsAny<int>()));

            var result = await _servicoAplicacaoMarvel.ObterHistorias(It.IsAny<int>());

            Assert.NotNull(result);
            Assert.IsType<List<HistoriaViewModel>>(result.ToList());
            Assert.Empty(result);
        }

        // Séries
        [Fact]
        public async Task DeveRetornarListaDeSeriesQuandoExistir()
        {
            var series = _fixture.CreateMany<SerieViewModel>();

            _repositorioMarvelMock.Setup(f => f.ObterSeries(It.IsAny<int>())).ReturnsAsync(series);

            var result = await _servicoAplicacaoMarvel.ObterSeries(It.IsAny<int>());

            Assert.IsType<List<SerieViewModel>>(result.ToList());
            Assert.NotNull(result);
        }

        [Fact]
        public async Task DeveRetornarListaVaziaQuandoNaoExistirSerie()
        {
            _repositorioMarvelMock.Setup(f => f.ObterSeries(It.IsAny<int>()));

            var result = await _servicoAplicacaoMarvel.ObterSeries(It.IsAny<int>());

            Assert.NotNull(result);
            Assert.IsType<List<SerieViewModel>>(result.ToList());
            Assert.Empty(result);
        }
    }
}
