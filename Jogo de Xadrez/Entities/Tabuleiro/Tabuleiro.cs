namespace Entites.Tabuleiro;

class Tabuleiro
{
    public int Linha {get; set;}
    public int Coluna {get; set;}
    private readonly Peca[,] Pecas;

    public Tabuleiro(int linha, int coluna)
    {
        this.Linha = linha;
        this.Coluna = coluna;
        this.Pecas = new Peca[linha, coluna];
    }

    public Peca GetPeca(int linha, int coluna)
    {
        return Pecas[linha,coluna];
    }
}