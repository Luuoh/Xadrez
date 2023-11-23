using System;
using Tabuleiro;

namespace Xadrez {
    internal class Torre : Peca {

        public Torre(Tabuleiros tabuleiro, Cor cor) : base(cor, tabuleiro) {
        }
        public override string ToString() {
            return "T";
        }
    }
}
