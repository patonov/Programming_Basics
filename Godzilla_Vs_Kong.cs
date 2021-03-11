using System;

namespace Godzilla_Vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double extrasOutfit = double.Parse(Console.ReadLine());

            double decore = budget * 0.1;
            double outfitTotal = extras * extrasOutfit;

            if (extras > 150)
            {
                outfitTotal *= 0.9;
            }

            double expenses = decore + outfitTotal;
            double rest = budget - expenses;
            double need = expenses - budget;

            if (expenses <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:F2} leva left.", rest);
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:F2} leva more.", need);
            }
        }
    }
}
