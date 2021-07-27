using System;

namespace _11th_exercise 
{
    class Program 
    {
        static void Main(string[] args) 
        {

            System.Console.WriteLine();
            Console.WriteLine("What's the number of lines in the array?");
            int m = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            Console.WriteLine("What's the number of columns in the array?");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            int[,] array = new int[m,n];

            for (int i = 0; i<m; i++) 
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j<n; j++) 
                {
                    array [i,j] = int.Parse(values[j]);
                }
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine("What's the number that you want to find?");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    if (array[i, j] == number) 
                    {
                        System.Console.WriteLine();
                        Console.WriteLine("Position (" + (i + 1) + "," + (j+1) + "):");

                        if (j > 0) 
                        {
                            Console.WriteLine("Left: " + array[i, j - 1]);
                        }
                        if (i > 0) 
                        {
                            Console.WriteLine("Up: " + array[i - 1, j]);
                        }
                        if (j < n - 1) 
                        {
                            Console.WriteLine("Right: " + array[i, j + 1]);
                        }
                        if (i < m - 1) 
                        {
                            Console.WriteLine("Down: " + array[i + 1, j]);
                        }
                    }
                }
            }     
        }
    }
}