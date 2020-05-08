using System.Buffers.Text;
using XadrezGame.Tabuleiro;

namespace XadrezGame.Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro.Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
