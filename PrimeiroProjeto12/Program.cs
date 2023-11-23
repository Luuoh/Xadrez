using System;
using Tabuleiro;
using Xadrez;

namespace PrimeiroProjeto12 {
    internal class Program {
        static void Main(string[] args) {

            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada) {

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tabuleiro.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tabuleiro, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);
                }

            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
    }
}