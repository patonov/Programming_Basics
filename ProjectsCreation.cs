using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int hours = number * 3;

            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", architect, hours, number);
        }
    }
}
