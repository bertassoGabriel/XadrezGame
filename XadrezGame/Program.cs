using System;
using XadrezGame.Tabuleiro;

namespace XadrezGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
        }
    }
}
