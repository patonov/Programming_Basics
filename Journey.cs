using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double costs = 0;
            string hosting = string.Empty;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    costs = budget * 0.3;
                }
                else if (season == "winter")
                {
                    costs = budget * 0.7;
                }

                if (season == "summer")
                {
                    hosting = "Camp";
                }
                else
                {
                    hosting = "Hotel";
                }
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("{0} - {1:F2}", hosting, costs);
            }
            else if (budget >= 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    costs = budget * 0.4;
                }
                else if (season == "winter")
                {
                    costs = budget * 0.8;
                }

                if (season == "summer")
                {
                    hosting = "Camp";
                }
                else
                {
                    hosting = "Hotel";
                }
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("{0} - {1:F2}", hosting, costs);
            }

            else
            {
                costs = budget * 0.9;
                hosting = "Hotel";

                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("{0} - {1:F2}", hosting, costs);
            }
        }
    }
}
