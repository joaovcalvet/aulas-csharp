using Entities.Tabuleiro;

namespace Entities.Xadrez.Peças;

class Rei : Peca
{
    public Rei(Tabuleiro.Tabuleiro tab, Cor cor):
    base(tab, cor) {}

    public override string ToString()
    {
        return "R";
    }
}