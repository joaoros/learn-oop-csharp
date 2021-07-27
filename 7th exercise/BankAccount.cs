using System; using System.Globalization;

namespace poo_s4___7 
{
    class BankAccount 
    {
        public int Number { get; private set; }
        public string  Customer { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string customer) 
        {
            Number = number;
            Customer = customer;
        }

        public BankAccount(int number, string customer, double balance) : this(number, customer) 
        {
            Balance = balance;
        }

        public void Deposit(double quantity) 
        {
            Balance += quantity;
        }

        public void Withdraw(double quantity) 
        {
            Balance -= quantity + 5.0;
        }

        public override string ToString() 
        {
            return "Conta "
                + Number
                + ", Titular: "
                + Customer
                + ", Saldo: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}