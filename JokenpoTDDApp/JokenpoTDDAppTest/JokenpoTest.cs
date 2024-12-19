using JokenpoTDDApp;
using JokenpoTDDApp.Enums;

namespace JokenpoTDDAppTest
{
    public class JokenpoTest
    {
        [Fact]
        public void Quando_Jogador1_Escolhe_Pedra_E_Jogador2_Escolhe_Tesoura_Retorna_Vitoria_Jogador1()
        {
            //arrange
            var jogo = new Jokenpo();

            //act
            var resultado = jogo.Jogar(Opcao.Pedra, Opcao.Tesoura);

            //assert (resultado esperado, resultado de fato)
            Assert.Equal(Resultado.Jogador1Venceu, resultado);
        }

        [Theory]
        [InlineData(Opcao.Papel, Opcao.Tesoura, Resultado.Jogador2Venceu)]
        [InlineData(Opcao.Papel, Opcao.Pedra, Resultado.Jogador1Venceu)]
        [InlineData(Opcao.Papel, Opcao.Papel, Resultado.Empate)]
        [InlineData(Opcao.Tesoura, Opcao.Papel, Resultado.Jogador1Venceu)]
        [InlineData(Opcao.Tesoura, Opcao.Pedra, Resultado.Jogador2Venceu)]
        [InlineData(Opcao.Tesoura, Opcao.Tesoura, Resultado.Empate)]
        [InlineData(Opcao.Pedra, Opcao.Papel, Resultado.Jogador2Venceu)]
        [InlineData(Opcao.Pedra, Opcao.Tesoura, Resultado.Jogador1Venceu)]
        [InlineData(Opcao.Pedra, Opcao.Pedra, Resultado.Empate)]
        public void Dados_Cenarios_De_Testte_O_Resultado_Esperado_E_Sucesso(Opcao jogada1, Opcao jogada2, Resultado resultadoJogo)
        {
            //arrange
            var jogo = new Jokenpo();

            //act
            var resultado = jogo.Jogar(jogada1, jogada2);

            //assert (resultado esperado, resultado de fato)
            Assert.Equal(resultadoJogo, resultado);
        }
    }
}