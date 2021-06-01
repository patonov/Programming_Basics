using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            string packageType = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0.00;
            double sum = 0.00;

            switch (townName)
            {
                case "Bansko":
                    if (packageType == "noEquipment")
                    {
                        price = 80;
                        if (vipDiscount == "yes")
                        {
                            price *= 0.95;
                        }
                    }
                    else if (packageType == "withEquipment")
                    {
                        price = 100;
                        if (vipDiscount == "yes")
                        {
                            price *= 0.90;
                        }
                    }
                    break;

                case "Borovets":
                    if (packageType == "noEquipment")
                    {
                        price = 80;
                        if (vipDiscount == "yes")
                        {
                            price *= 0.95;
                        }
                    }
                    else if (packageType == "withEquipment")
                    {
                        price = 100;
                        if (vipDiscount == "yes")
                        {
                            price *= 0.90;
                        }
                    }
                    break;

                case "Varna":
                    if (packageType == "noBreakfast")
                    {
                        price = 100;
                        if (vipDiscount == "yes")
                        {
                            price *= 0.93;
                        }
                    }
                    else if (packageType == "withBreakfast")
                    {
                        price = 130;
                        if (vipDiscount == "yes")
                        {
                            price *= 0.88;
                        }
                    }
                    break;
                case "Burgas":
                    if (packageType == "noBreakfast")
                    {
                        price = 100;
                        if (vipDiscount == "yes")
                        {
                            price *= 0.93;
                        }
                    }
                    else if (packageType == "withBreakfast")
                    {
                        price = 130;
                        if (vipDiscount == "yes")
                        {
                            price *= 0.88;
                        }
                    }
                    break;
            }
            sum = days * price;




            if (packageType != "noEquipment" && packageType != "withBreakfast" && packageType != "withEquipment" && packageType != "noBreakfast")
            {
                Console.WriteLine("Invalid input!");
            }
            else if (townName != "Bansko" && townName != "Borovets" && townName != "Burgas" && townName != "Varna")
            {
                Console.WriteLine("Invalid input!");
            }
            else if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
            {
                Console.WriteLine("The price is {0:f2}lv! Have a nice time!", sum);
            }
        }
    }
}
