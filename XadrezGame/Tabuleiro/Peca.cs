namespace XadrezGame.Tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao;
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        // Coloca peça no tabuleiro
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
        //-------------------------------------------
        



        // Incrementa quantidade de movimentos da peça
        public void incrementarQteMovimento()
        {
            qteMovimentos++;
        }

        public void decrementarQteMovimento()
        {
            qteMovimentos--;
        }
        //-------------------------------------------




        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
