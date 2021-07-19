using System;
using System.Globalization;

namespace FourthExercise {
    class Program {
        static void Main(string[] args) {
            Funcionario employee = new Funcionario();

            Console.Write("Nome: ");
            employee.Name = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + employee);

            Console.Write("Digite a porcentagem ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.AddMoney(porcentagem);

            Console.WriteLine("Dados atualizafos: " + employee);

        }
    }
}
