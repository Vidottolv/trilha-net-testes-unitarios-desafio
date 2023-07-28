using TestesUnitarios.Desafio.Console.Services;
using Xunit;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes = new ValidacoesString();

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            // Arrange
            var texto = "matrix"; // Corrigir a variável "texto"
            var resultadoEsperado = 6; // Corrigir a variável "resultadoEsperado"

            // Act
            var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            // Arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "qualquer";

            // Act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado); // Corrigir a chamada do método

            // Assert
            Assert.True(resultado); // Corrigir o Assert.True com base no retorno da chamada ao método
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            // Arrange
            var texto = "Esse é um texto qualquer";
            var textoProcurado = "teste";

            // Act
            var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

            // Assert
            Assert.False(resultado); // Corrigir o Assert.False com base no retorno da chamada ao método
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurada()
        {
            // Arrange
            var texto = "Começo, meio e fim do texto procurado";
            var textoProcurado = "procurado"; // Corrigir a variável "textoProcurado"

            // Act
            var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

            // Assert
            Assert.True(resultado);
        }
    }
}
