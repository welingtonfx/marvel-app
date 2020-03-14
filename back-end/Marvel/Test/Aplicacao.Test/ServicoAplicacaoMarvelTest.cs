using Aplicacao;
using AutoFixture;
using Dominio.Interface.Infra;
using Dominio.Model.Personagem;
using Dominio.Model.Personagens;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Test.Aplicacao.Test
{

    public class ServicoAplicacaoMarvelTest
    {
        private readonly Fixture _fixture;
        private readonly Mock<IRepositorioMarvel> _repositoririoMarvelMock;
        private readonly ServicoAplicacaoMarvel _servicoAplicacaoMarvel;

        public ServicoAplicacaoMarvelTest()
        {
            _fixture = new Fixture();
            _repositoririoMarvelMock = new Mock<IRepositorioMarvel>();
            _servicoAplicacaoMarvel = new ServicoAplicacaoMarvel(_repositoririoMarvelMock.Object);
        }

        [Fact]
        public async Task DeveObterPersonagens()
        {
            var personagens = _fixture.Create<Personagens>();

            _repositoririoMarvelMock.Setup(f => f.ObterPersonagens(It.IsAny<CancellationToken>())).ReturnsAsync(personagens);

            var result = await _servicoAplicacaoMarvel.ObterPersonagens(It.IsAny<CancellationToken>());

            Assert.IsType<Personagens>(result);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task NaoDeveObterPersonagens()
        {
            _repositoririoMarvelMock.Setup(f => f.ObterPersonagens(It.IsAny<CancellationToken>()));

            var result = await _servicoAplicacaoMarvel.ObterPersonagens(It.IsAny<CancellationToken>());

            Assert.Null(result);

        }

        [Fact]
        public async Task DeveObterPersonagem()
        {
            var personagem = _fixture.Create<Personagem>();

            _repositoririoMarvelMock.Setup(f => f.ObterPersonagem(It.IsAny<int>(), It.IsAny<CancellationToken>())).ReturnsAsync(personagem);

            var result = await _servicoAplicacaoMarvel.ObterPersonagem(It.IsAny<int>(), It.IsAny<CancellationToken>());

            Assert.IsType<Personagem>(result);
            Assert.NotNull(result);
        }
    }
}
