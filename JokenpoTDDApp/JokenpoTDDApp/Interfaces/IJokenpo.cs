using JokenpoTDDApp.Enums;

namespace JokenpoTDDApp.Interfaces
{
    public interface IJokenpo
    {
        public Resultado Jogar(Opcao jogador1, Opcao jogador2);
    }
}
