using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int other = int.Parse(Console.ReadLine());
            double costs = dogs * 2.5 + other * 4;
            Console.Write("{0:F2}", costs);
            Console.Write(" lv.");
        }
    }
}
