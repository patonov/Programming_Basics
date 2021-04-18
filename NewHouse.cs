using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double flowers = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0;

            if (type == "Roses")
            {
                if (flowers > 80)
                {
                    price = (flowers * 5) - (flowers * 5) * 0.1;
                }
                else
                {
                    price = (flowers * 5);
                }
            }
            else if (type == "Dahlias")
            {
                if (flowers > 90)
                {
                    price = (flowers * 3.80) - (flowers * 3.80) * 0.15;
                }
                else
                {
                    price = (flowers * 3.80);
                }
            }
            else if (type == "Tulips")
            {
                if (flowers > 80)
                {
                    price = (flowers * 2.80) - (flowers * 2.80) * 0.15;
                }
                else
                {
                    price = (flowers * 2.80);
                }
            }
            else if (type == "Narcissus")
            {
                if (flowers < 120)
                {
                    price = (flowers * 3) + (flowers * 3) * 0.15;
                }
                else
                {
                    price = (flowers * 3);
                }
            }
            else if (type == "Gladiolus")
            {
                if (flowers < 80)
                {
                    price = (flowers * 2.50) + (flowers * 2.50) * 0.2;
                }
                else
                {
                    price = (flowers * 3);
                }
            }

            if (budget >= price)
            {
                double moneyLeft = budget - price;

                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", flowers, type, moneyLeft);
            }
            else
            {
                double moneyNeeded = price - budget;

                Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyNeeded);
            }
        }
    }
}
