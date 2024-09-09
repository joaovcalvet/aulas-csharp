using Entites.Tabuleiro;

namespace Game;

class ImprimirTabuleiro
{
    public static void Imprimir(Tabuleiro tab)
    {
        for (int linha = 0; linha < tab.Linha; linha++)
        {
            for (int coluna = 0; coluna < tab.Coluna; coluna++)
            {
                if(tab.GetPeca(linha, coluna) == null)
                {
                    Console.Write("- ");
                    continue;
                }

                Console.Write(tab.GetPeca(linha, coluna) + " ");
            }
            Console.WriteLine();
        }
    }
}