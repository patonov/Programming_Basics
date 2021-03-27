using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFirst = int.Parse(Console.ReadLine());
            int numberSecond = int.Parse(Console.ReadLine());

            if (numberFirst > numberSecond)
            {
                Console.WriteLine(numberFirst);
            }
            else
            {
                Console.WriteLine(numberSecond);
            }
        }
    }
}
