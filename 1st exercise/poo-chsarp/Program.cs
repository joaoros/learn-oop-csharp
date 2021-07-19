using System;
using System.Globalization;

namespace poo_chsarp
{
    class Program
    {
        static void Main(string[] args)
        {

            Person firstPerson = new Person();
            Person secondPerson = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            firstPerson.name = Console.ReadLine();
            Console.Write("Idade: ");
            firstPerson.age = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            secondPerson.name = Console.ReadLine();
            Console.Write("Idade: ");
            secondPerson.age = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (firstPerson.age > secondPerson.age) {
                Console.WriteLine(firstPerson.name + " é a pessoa mais velha!");
            }

            else if (secondPerson.age > firstPerson.age) {
                Console.WriteLine(secondPerson.name + " é a pessoa mais velha!");
            }

            else {
                Console.WriteLine("A idade de ambos é igual!");
            }
        }
    }
}
