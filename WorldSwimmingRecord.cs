using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double timeNeeded = distance * timeForOneMeter;

            double slowTimes = Math.Round(distance / 15);

            double slowering = slowTimes * 12.5;

            double totalTime = timeNeeded + slowering;

            if (record > totalTime)
            {
                Console.WriteLine(" Yes, he succeeded! The new world record is {0:F2} seconds.", totalTime);
            }

            else
            {
                double late = totalTime - record;
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", late);
            }
        }
    }
}
