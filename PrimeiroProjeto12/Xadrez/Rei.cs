using System;
using Tabuleiro;

namespace Xadrez {
    internal class Rei : Peca{

        public Rei(Tabuleiros tabuleiro, Cor cor) : base(cor, tabuleiro) {
        }
        public override string ToString() {
            return "R";
        }
    }
}
