using System;
using _12th_exercise.Entities;
using _12th_exercise.Entities.Enums;

namespace _12th_exercise {
    class Program  {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            System.Console.WriteLine(order);
        }
    }
}
