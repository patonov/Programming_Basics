using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            string type = String.Empty;
            double priceApartment = 0;
            double priceStudio = 0;

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    priceStudio = (nights * 50) - (nights * 50 * 0.05);
                }
                else if (nights > 14)
                {
                    priceApartment = (nights * 65) - (nights * 65 * 0.1);
                    priceStudio = (nights * 50) - (nights * 50 * 0.3);
                }
                else
                {
                    priceApartment = nights * 65;
                    priceStudio = nights * 50;
                }
            }

            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    priceApartment = (nights * 68.70) - (nights * 68.70 * 0.1);
                    priceStudio = (nights * 75.20) - (nights * 75.20 * 0.2);
                }
                else
                {
                    priceApartment = nights * 68.70;
                    priceStudio = nights * 75.20;
                }
            }


            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    priceApartment = (nights * 77) - (nights * 77 * 0.1);
                    priceStudio = nights * 76;
                }
                else
                {
                    priceApartment = nights * 77;
                    priceStudio = nights * 76;
                }
            }
            Console.WriteLine("Apartment: {0:F2} lv.", priceApartment);
            Console.WriteLine("Studio: {0:F2} lv.", priceStudio);
        }
    }
    }
}
