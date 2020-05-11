using System;
using XadrezGame.Tabuleiro;
using XadrezGame.Xadrez;

namespace XadrezGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
        }
    }
}
