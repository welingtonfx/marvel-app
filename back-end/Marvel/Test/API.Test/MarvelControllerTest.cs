﻿using API.Controllers;
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
    public class MarvelControllerTest
    {
        private PersonagemController personagemController;
        private readonly Mock<IServicoAplicacaoMarvel> servicoAplicacaoMarvel;
        private readonly Fixture _fixture;
        public MarvelControllerTest()
        {
            _fixture = new Fixture();
            servicoAplicacaoMarvel = new Mock<IServicoAplicacaoMarvel>();
            personagemController = new PersonagemController(servicoAplicacaoMarvel.Object);
        }

        [Fact]
        public async Task Should()
        {
            var personagens = _fixture.CreateMany<PersonagensViewModel>();

            servicoAplicacaoMarvel.Setup(p => p.ObterPersonagens(It.IsAny<CancellationToken>())).ReturnsAsync(personagens);

            var result = await personagemController.ObterPersonagens(It.IsAny<CancellationToken>());

            Assert.IsType<ActionResult<IEnumerable<PersonagensViewModel>>>(result);
            Assert.IsType<OkObjectResult>(result.Result);
        }
    }
}
