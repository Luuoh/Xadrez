using System;
using Tabuleiro;

namespace Xadrez {
    internal class Torre : Peca {

        public Torre(Tabuleiros tabuleiro, Cor cor) : base(cor, tabuleiro) {
        }
        public override string ToString() {
            return "T";
        }

        private bool podeMover(Posicao pos) {
            Peca p = Tabuleiro.peca(pos);
            return p == null || p.Cor != Cor;
        }
        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);

            // Norte
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor) {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }
            // Leste
            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor) {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }
            // Sul
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor) {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }
            // Oeste
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor) {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }
            return mat;

        }
    }
}
