using System;
using _20th_exercise.Entities;

namespace _20th_exercise {
    class Program {
        static void Main(string[] args) {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client { Name = "João", Email = "joao@gmail.com"};

            Console.WriteLine(a.Equals(b));
        }
    }
}
