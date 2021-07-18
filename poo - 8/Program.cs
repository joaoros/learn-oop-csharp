using System; using System.Globalization;

namespace poo___8 {
	class Program {
		static void Main(string[] args) {

			Rental[] rent = new Rental[10];

            System.Console.Write("How many rooms will be rented? ");
            int roomsNumber = int.Parse(Console.ReadLine()); 

            System.Console.WriteLine();
            for (int i = 1; i <= roomsNumber; i++) {
                System.Console.WriteLine($"Rent #{i}");
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Email: ");
                string email = Console.ReadLine();
                System.Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                System.Console.WriteLine();
                rent[room] = new Rental(name, email);
            } 

            System.Console.WriteLine();
            System.Console.WriteLine("Occupied rooms: "); 
            for (int i = 0; i < 10; i++) {
                if (rent[i] != null) {
                    System.Console.WriteLine(i + ":" + rent[i]);
                }
            }

		}
	}
}
