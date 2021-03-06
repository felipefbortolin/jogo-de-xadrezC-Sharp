using tabuleiro;
namespace xadrez
{
    class PosicaoXadrez
    {
        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public char Coluna { get; set; }
        public int Linha { get; set; }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }
    }
}