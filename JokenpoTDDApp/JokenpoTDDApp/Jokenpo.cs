using JokenpoTDDApp.Enums;
using JokenpoTDDApp.Interfaces;

namespace JokenpoTDDApp
{
    public class Jokenpo : IJokenpo
    {
        public Resultado Jogar(Opcao jogador1, Opcao jogador2)
        {
            if (jogador1 == Opcao.Papel && jogador2 == Opcao.Tesoura)
            {
                return Resultado.Jogador2Venceu;
            }
            if (jogador1 == Opcao.Pedra && jogador2 == Opcao.Tesoura)
            {
                return Resultado.Jogador1Venceu;
            }
            if (jogador1 == Opcao.Pedra && jogador2 == Opcao.Pedra)
            {
                return Resultado.Empate;
            }
            if (jogador1 == Opcao.Tesoura && jogador2 == Opcao.Pedra)
            {
                return Resultado.Jogador2Venceu;
            }
            if (jogador1 == Opcao.Papel && jogador2 == Opcao.Pedra)
            {
                return Resultado.Jogador1Venceu;
            }
            if (jogador1 == Opcao.Pedra && jogador2 == Opcao.Papel)
            {
                return Resultado.Jogador2Venceu;
            }
            if (jogador1 == Opcao.Tesoura && jogador2 == Opcao.Papel)
            {
                return Resultado.Jogador1Venceu;
            }

            return Resultado.Empate;
        }
    }
}
