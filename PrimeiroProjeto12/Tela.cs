using System;
using Tabuleiro;

namespace PrimeiroProjeto12 {
    internal class Tela {
        public static void imprimirTabuleiro(Tabuleiros tabuleiro) {

            for (int i = 0; i<tabuleiro.Linhas; i++) {
                for (int j = 0; j < tabuleiro.Colunas; j++) {
                    if (tabuleiro.peca(i, j) == null) {
                        Console.Write("- ");
                    }
                    else {
                        Console.Write(tabuleiro.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
