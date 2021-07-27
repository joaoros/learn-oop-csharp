using System;
using System.Globalization;

namespace poo_s4_3 
{

    class Program 
    {

        static void Main(string[] args) 
        {

            Retangulo rectangle = new Retangulo();

            Console.WriteLine("Informe a largura e altura do retângulo:");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área: " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonasl: " + rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + rectangle.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
