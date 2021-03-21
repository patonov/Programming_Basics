using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double price = area * 7.61;
            double discount = 0.18 * price;
            double finalPrice = price - discount;

            Console.WriteLine("The final price is: {0:F2} lv.", finalPrice);
            Console.WriteLine("The discount is: {0:F2} lv.", discount);
        }
    }
}
