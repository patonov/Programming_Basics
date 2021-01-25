using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            double balance = 0.00;

            while (counter < n)
            {
                double amount = double.Parse(Console.ReadLine());

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance = balance + amount;
                Console.WriteLine("Increase: {0:F2}", amount);
                counter++;
            }

            Console.WriteLine("Total: {0:F2}", balance);
        }
    }
}
