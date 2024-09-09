namespace Game;

using Entities.Tabuleiro;
using Entities.Xadrez.Peças;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(8,8);

        tab.PosicionarPeca(new Rei(tab, Cor.PRETO), new Posicao(0,4));
        tab.PosicionarPeca(new Torre(tab, Cor.PRETO), new Posicao(0,0));
        tab.PosicionarPeca(new Torre(tab, Cor.PRETO), new Posicao(0,7));

        ImprimirTabuleiro.Imprimir(tab);
    }   
}