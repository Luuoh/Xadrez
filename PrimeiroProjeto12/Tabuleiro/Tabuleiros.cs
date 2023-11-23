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
    }
}
