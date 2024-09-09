namespace Game;

using Entites.Tabuleiro;
using Entities.Tabuleiro;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(8,8);
        ImprimirTabuleiro.Imprimir(tab);
    }   
}