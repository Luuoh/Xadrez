using System;

namespace Tabuleiro {
    abstract class Peca {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeDeMovimentos { get; protected set; }
        public Tabuleiros Tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiros tabuleiro) {
            this.Posicao = null;
            this.Cor = cor;
            this.Tabuleiro = tabuleiro;
            this.QuantidadeDeMovimentos = 0;
        }

        public void incrementarQuantidadeDeMovimentos() {
            QuantidadeDeMovimentos++;
        }

        public void decrementarQuantidadeDeMovimentos() {
            QuantidadeDeMovimentos--;
        }

        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < Tabuleiro.Linhas; i++) {
                for (int j = 0; j < Tabuleiro.Colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos) {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] movimentosPossiveis();

    }
}
