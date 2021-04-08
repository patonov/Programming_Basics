using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int libraryCapacity = int.Parse(Console.ReadLine());

            int counter = 1;
            string searchBook = string.Empty;

            while (counter <= libraryCapacity)
            {
                searchBook = Console.ReadLine();

                if (book == searchBook)
                {
                    Console.WriteLine("You checked {0} books and found it.", counter - 1);
                    break;
                }

                if (counter == libraryCapacity)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine("You checked {0} books.", libraryCapacity);
                }

                counter++;
            }
        }
    }
}
