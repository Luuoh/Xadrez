using System;
using Tabuleiro;

namespace Xadrez {
    internal class Peao : Peca {

        private PartidaDeXadrez partida;
        public Peao(Tabuleiros tabuleiros, Cor cor, PartidaDeXadrez partida) : base(cor, tabuleiros) {
            this.partida = partida;
        }

        public override string ToString() {
            return "P";
        }

        private bool existeInimigo(Posicao pos) {
            Peca p = Tabuleiro.peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool livre(Posicao pos) {
            return Tabuleiro.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);

            if (Cor == Cor.Branca) {
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(pos) && livre(pos) && QuantidadeDeMovimentos == 0) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tabuleiro.posicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tabuleiro.posicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // #JogadaEspecial (En Passant)
                if (Posicao.Linha == 3) {
                    Posicao esqueda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Tabuleiro.posicaoValida(esqueda) && existeInimigo(esqueda) && Tabuleiro.peca(esqueda) == partida.vulneravelEnPassant){
                        mat[esqueda.Linha - 1, esqueda.Coluna] = true;
                    }
                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Tabuleiro.posicaoValida(direita) && existeInimigo(direita) && Tabuleiro.peca(direita) == partida.vulneravelEnPassant) {
                        mat[direita.Linha - 1, direita.Coluna] = true;
                    }
                }
            }
            else {
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(pos) && livre(pos) && QuantidadeDeMovimentos == 0) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tabuleiro.posicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tabuleiro.posicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // #JogadaEspecial (En Passant)
                if (Posicao.Linha == 4) {
                    Posicao esqueda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Tabuleiro.posicaoValida(esqueda) && existeInimigo(esqueda) && Tabuleiro.peca(esqueda) == partida.vulneravelEnPassant) {
                        mat[esqueda.Linha + 1, esqueda.Coluna] = true;
                    }
                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Tabuleiro.posicaoValida(direita) && existeInimigo(direita) && Tabuleiro.peca(direita) == partida.vulneravelEnPassant) {
                        mat[direita.Linha + 1, direita.Coluna] = true;
                    }
                }
            }

            return mat;
        }
    }
}
