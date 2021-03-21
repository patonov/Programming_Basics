using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double liters = volume * 0.001;
            double perCents = percent * 0.01;
            double litersNeeded = liters * (1 - perCents);

            Console.WriteLine("{0:F3}", litersNeeded);
        }
    }
}
