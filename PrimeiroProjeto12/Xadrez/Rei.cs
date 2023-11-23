using System;
using Tabuleiro;

namespace Xadrez {
    internal class Rei : Peca{

        public Rei(Tabuleiros tabuleiro, Cor cor) : base(cor, tabuleiro) {
        }
        public override string ToString() {
            return "R";
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
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // Nordeste
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // Leste
            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // Sudeste
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // Sul
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // Sudoeste
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // Oeste
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            // Noroeste
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;
        }
    }
}
