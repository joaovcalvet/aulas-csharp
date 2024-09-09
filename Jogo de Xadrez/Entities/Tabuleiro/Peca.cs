namespace Entities.Tabuleiro;

class Peca
{
    public Posicao? PecaPosicao {get; set;}
    public Cor PecaCor {get; protected set;}
    public int QtdMovimentos {get; protected set;}
    public Tabuleiro Tab {get; protected set;}

    public Peca(Tabuleiro tab, Cor cor)
    {
        this.Tab = tab;
        this.PecaCor = cor;
        this.QtdMovimentos = 0;
    }
}