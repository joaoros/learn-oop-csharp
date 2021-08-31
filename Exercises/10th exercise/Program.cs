using System;

namespace Course 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Qual será o tamanho da matriz quadrada? (E.g digite 3 para uma matriz 3x3");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) 
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) 
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            System.Console.WriteLine();
            Console.Write("Diagonal principal: ");

            for (int i = 0; i < n; i++) 
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    if (mat[i,j] < 0) 
                    {
                        count++;
                    }
                }
            }
            
            Console.WriteLine("Números negativos: " + count);
        }
    }
}