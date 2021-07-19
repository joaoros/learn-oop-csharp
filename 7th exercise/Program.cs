using System; using System.Globalization;

namespace poo_s4___7 {
    public class Program {
        static void Main(string[] args) {

            BankAccount account;

            Console.Write("Entre o número da conta: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string customer = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 's' || answer == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(number, customer, balance);
            }
            else {
                account = new BankAccount(number, customer);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");    
            double quantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(quantity);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(quantity);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account);
        }
    }
}
