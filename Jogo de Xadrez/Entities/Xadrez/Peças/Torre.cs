using Entities.Tabuleiro;

namespace Entities.Xadrez.Peças;

class Torre : Peca
{
    public Torre(Tabuleiro.Tabuleiro tab, Cor cor):
    base(tab, cor) {}

    public override string ToString()
    {
        return "T";
    }
}