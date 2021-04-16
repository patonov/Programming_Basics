using System;

namespace NumSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggest = int.MinValue;
            int smallest = int.MaxValue;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < smallest)
                {
                    smallest = num;
                }
                if (num > biggest)
                {
                    biggest = num;
                }
            }
            Console.WriteLine("Max number: {0}", biggest);
            Console.WriteLine("Min number: {0}", smallest);
        }
    }
}
