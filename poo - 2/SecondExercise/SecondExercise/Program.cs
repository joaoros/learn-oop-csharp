using System;
using System.Globalization;

namespace SecondExercise
{
    class Program
    {
        static void Main(string[] args) {

            Person firstPerson = new Person();
            Person secondPerson = new Person();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            firstPerson.name = Console.ReadLine();
            Console.Write("Salário: ");
            firstPerson.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(" ");

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            secondPerson.name = Console.ReadLine();
            Console.Write("Salário: ");
            secondPerson.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average;
            average = (firstPerson.salary + secondPerson.salary) / 2;

            Console.Write("A média dos salários é igual a: " + average.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" ");
        }
    }
}
