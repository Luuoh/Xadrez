using System;

namespace Tabuleiro {
    internal class Peca {
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

    }
}
