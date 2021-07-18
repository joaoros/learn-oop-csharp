namespace poo_s4___6 {
    public class CurrencyConverter {
        public static double IOF = 6.0;

        public static double DollarToReal(double quantity, double priceQuotation) {
            double total = quantity * priceQuotation;
            return total + total * IOF/100;
        }
    }
}