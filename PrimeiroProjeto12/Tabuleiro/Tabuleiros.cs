using System;

namespace Tabuleiro {
    internal class Tabuleiros {
        public int Linhas { get; set; }
        public int Colunas { get; set;}
        private Peca[,] Pecas;

        public Tabuleiros(int linhas, int colunas) {
            this.Linhas = linhas;
            this.Colunas = colunas;
            Pecas = new Peca[linhas,colunas];
        }

        public Peca peca(int linhas, int colunas) {
            return Pecas[linhas, colunas];
        }
        public void colocarPeca(Peca p, Posicao pos) {
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
