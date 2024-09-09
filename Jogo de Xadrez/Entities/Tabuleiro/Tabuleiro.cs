namespace Entities.Tabuleiro;

class Tabuleiro
{
    public int Linhas {get; set;}
    public int Colunas {get; set;}
    private readonly Peca[,] Pecas;

    public Tabuleiro(int linhas, int colunas)
    {
        this.Linhas = linhas;
        this.Colunas = colunas;
        this.Pecas = new Peca[linhas, colunas];
    }

    public Peca GetPeca(int linha, int coluna)
    {
        return Pecas[linha,coluna];
    }

    public void PosicionarPeca(Peca peca, Posicao posicao)
    {
        Pecas[posicao.Linha, posicao.Coluna] = peca;
        peca.PecaPosicao = posicao; 
    }
}