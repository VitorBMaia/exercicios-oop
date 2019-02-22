using System;
using Xunit;
using Assassino;

namespace Assassino.Test
{
    public class TesteResposta
    {
        [Fact]
        public void TestaOMetodoChecarResposta()
        {
        var valorEsperado = 0;
        Resposta resposta = new Resposta();
        
        Assert.Equal(valorEsperado, resposta.ChecarResposta(resposta.Fato[0], resposta.Fato[1], resposta.Fato[2]));

        }

        [Fact]
        public void TestaRegraDeNegocio()
        {
            var valorEsperado = -1;
            Resposta resposta = new Resposta();

            Assert.Equal(valorEsperado, resposta.ChecarResposta(-1, 1, 1));
        }

        [Fact]
        public void TestaLimites()
        {
            var valorEsperado = -1;
            Resposta resposta = new Resposta();
            Assert.Equal(valorEsperado, resposta.ChecarResposta(10, 4, 3));
            Assert.Equal(valorEsperado, resposta.ChecarResposta(2, 11, 3));
            Assert.Equal(valorEsperado, resposta.ChecarResposta(2, 4, 11));
        }
    }
}
