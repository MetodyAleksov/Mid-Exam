using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double Total = 0;
            for (int i = 0; i < orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                double pricePerCoffee = (days * capsuleCount) * pricePerCapsule;
                Total += pricePerCoffee;
                Console.WriteLine($"The price for the coffee is: ${pricePerCoffee:f2}");
            }
            Console.WriteLine($"Total: ${Total:f2}");
            //Got 100/100
        }
    }
}
