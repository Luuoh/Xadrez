using System;
using Tabuleiro;
using Xadrez;

namespace PrimeiroProjeto12 {
    internal class Program {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
        }
    }
}