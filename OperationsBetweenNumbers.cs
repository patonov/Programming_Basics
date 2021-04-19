using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double sum = n1 + n2;
            double difference = n1 - n2;
            double multiply = n1 * n2;
            double devide = n1 / n2;
            double mdev = n1 % n2;

            if (symbol.Equals('+'))
            {
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, symbol, n2, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, symbol, n2, sum);
                }
            }

            if (symbol.Equals('-'))
            {
                if (difference % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, symbol, n2, difference);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, symbol, n2, difference);
                }
            }

            if (symbol.Equals('*'))
            {
                if (multiply % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, symbol, n2, multiply);
                }
                else if (multiply % 2 != 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, symbol, n2, multiply);
                }
            }

            if (symbol.Equals('/') && n2 != 0)
            {
                Console.WriteLine("{0} / {1} = {2:F2}", n1, n2, devide);
            }

            if (symbol.Equals('%') && n2 != 0)
            {
                Console.WriteLine("{0} % {1} = {2}", n1, n2, mdev);
            }
            else if (n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
        }
    }
}
