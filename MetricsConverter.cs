using System;

namespace MetricsConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "cm")
            {
                number /= 100;
            }

            else if (input == "mm")
            {
                number /= 1000;
            }

            if (output == "cm")
            {
                number *= 100;
            }

            else if (output == "mm")
            {
                number *= 1000;
            }

            Console.WriteLine("{0:F3}", number);

        }
    }
}
