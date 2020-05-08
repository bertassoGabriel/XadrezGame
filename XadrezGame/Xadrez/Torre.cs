using XadrezGame.Tabuleiro;

namespace XadrezGame.Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro.Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
