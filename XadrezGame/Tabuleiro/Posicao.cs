﻿namespace XadrezGame.Tabuleiro
{
    class Posicao
    {
        public int linha;
        public int coluna;

        public Posicao()
        {
        }
        
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }




        // Altera a Posição
        public void definirValores(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }
        //-------------------------------------------




        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
