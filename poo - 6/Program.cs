using System;

namespace poo_s4___6 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual é a cotação do Dolár?");
            double priceQuotation = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos doláres você vai comprar?");
            double quantity = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double result = CurrencyConverter.DollarToReal(quantity, priceQuotation);

            Console.WriteLine("O valor a ser pago em reais é: " + result.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));

        }
    }
}
