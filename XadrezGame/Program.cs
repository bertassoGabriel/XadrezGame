using System;
using XadrezGame.Tabuleiro;

namespace XadrezGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4);
            Console.WriteLine("Posição: " + P);

            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);
        }
    }
}
