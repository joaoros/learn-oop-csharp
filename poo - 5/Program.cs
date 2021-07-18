using System;
using System.Globalization;

namespace poo_s4___5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno student = new Aluno();

            Console.Write("Nome do aluno: ");
            student.Name = Console.ReadLine();
            Console.Write("Digite as notas do aluno: ");
            student.FirstGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.SecondGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.ThirdGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final: " + student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));

            if (student.IsApproved()) {
                Console.WriteLine("Aprovado");
            }
            else {
                Console.WriteLine("Reprovado, faltaram "
                    + student.RemainingGrade().ToString("F2", CultureInfo.InvariantCulture) 
                    + " Pontos :(");
            }
        }
    }
}
