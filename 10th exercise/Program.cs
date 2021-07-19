using System;

namespace poo___10 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual o tamanho da matriz? ");
            int n = int.Parse(Console.Readline());

            int[,] mat = new int[n,n];

            for (int i = 0; i<n; i++) {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j<n; j++) {
                    mat[i,j] = int.Parse(valores[j]);
                }
            }
        }
    }
}