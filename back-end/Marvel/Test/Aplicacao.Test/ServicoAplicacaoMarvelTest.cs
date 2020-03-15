using Aplicacao;
using AutoFixture;
using Dominio.Interface.Infra;
using Dominio.Model.Personagem;
using Dominio.Model.Personagens;
using Dominio.ViewModel;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Test.Aplicacao.Test
{

    public class ServicoAplicacaoMarvelTest
    {
        private readonly Fixture _fixture;
        private readonly Mock<IRepositorioMarvel> _repositorioMarvelMock;
        private readonly ServicoAplicacaoMarvel _servicoAplicacaoMarvel;

        public ServicoAplicacaoMarvelTest()
        {
            _fixture = new Fixture();
            _repositorioMarvelMock = new Mock<IRepositorioMarvel>();
            _servicoAplicacaoMarvel = new ServicoAplicacaoMarvel(_repositorioMarvelMock.Object);
        }

        [Fact]
        public async Task DeveObterPersonagens()
        {
            var personagens = _fixture.Create<Personagens>();

            _repositorioMarvelMock.Setup(f => f.ObterPersonagens(It.IsAny<CancellationToken>())).ReturnsAsync(personagens);

            var result = await _servicoAplicacaoMarvel.ObterPersonagens(It.IsAny<CancellationToken>());

            Assert.IsType<List<PersonagensViewModel>>(result.ToList());

            Assert.NotNull(result);
        }

        [Fact]
        public async Task NaoDeveObterPersonagens()
        {
            _repositorioMarvelMock.Setup(f => f.ObterPersonagens(It.IsAny<CancellationToken>()));

            var result = await _servicoAplicacaoMarvel.ObterPersonagens(It.IsAny<CancellationToken>());

            Assert.Null(result);
        }

        [Fact]
        public async Task DeveObterPersonagem()
        {
            var personagem = _fixture.Create<Personagem>();

            _repositorioMarvelMock.Setup(f => f.ObterPersonagem(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(personagem);

            var result = await _servicoAplicacaoMarvel.ObterPersonagem(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<Personagem>(result);
            Assert.NotNull(result);
        }
    }
}
