using System;
using System.Globalization;

namespace FourthExercise 
{
    class Funcionario 
    {

        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary() 
        {
            return GrossSalary - Tax;
        }

        public void AddMoney(double porcentagem) 
        {
            GrossSalary += (GrossSalary * porcentagem / 100.0);
        }

        public override string ToString() 
        {
            return Name + ", R$ " + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
