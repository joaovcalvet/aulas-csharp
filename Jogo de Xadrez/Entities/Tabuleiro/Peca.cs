using Entities.Tabuleiro;

namespace Entites.Tabuleiro;

class Peca
{
    public Posicao PecaPosicao {get; set;}
    public Cor PecaCor {get; protected set;}
    public int QtdMovimentos {get; protected set;}
    public Tabuleiro Tab {get; protected set;}

    public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
    {
        this.Tab = tab;
        this.PecaCor = cor;
        this.QtdMovimentos = 0;
        this.PecaPosicao = posicao;
    }
}