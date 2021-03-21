using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            double additionalCostsPercent = double.Parse(Console.ReadLine());


            if (nights > 7)
            {
                nightPrice *= 0.95;
            }

            double travelCosts = nights * nightPrice;
            double additionalCosts = (additionalCostsPercent / 100) * budget;
            double totalCosts = travelCosts + additionalCosts;



            if (budget >= totalCosts)
            {
                double moneyLeft = budget - totalCosts;
                Console.WriteLine("Ivanovi will be left with {0:f2} leva after vacation.", moneyLeft);
            }
            else
            {
                double moneyNeeded = totalCosts - budget;
                Console.WriteLine("{0:f2} leva needed.", moneyNeeded);
            }
        }
    }
}
