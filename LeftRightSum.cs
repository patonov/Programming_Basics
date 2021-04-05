using System;

namespace LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;
            int num = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                leftSum = leftSum + num;
            }

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                rightSum = rightSum + num;
            }


            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(rightSum - leftSum));
            }
        }
    }
}
