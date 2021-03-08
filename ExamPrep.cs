using System;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string lastproblem = "a";
            double count = 0;
            double pcount = 0;
            double SM = 0;
            int evalution = 1;
            while (true)
            {
                string problem = Console.ReadLine();
                if (problem == "Enough")
                {
                    if (count != 0)
                    {
                        Console.WriteLine($"Average score: {(SM) / count:F2}");
                        Console.WriteLine(("Number of problems: ") + count);
                        Console.WriteLine(("Last problem: ") + lastproblem);
                        break;
                    }
                    else
                    {

                        int count1 = 1;
                        Console.WriteLine(("Average score: ") + (SM) / count1);
                        Console.WriteLine(("Number of problems: ") + count);
                        Console.WriteLine(("Last problem: ") + "not");
                    }
                }

                else
                {
                    evalution = int.Parse(Console.ReadLine());


                    if (evalution < 5)
                    {
                        pcount++;

                        if (pcount == a)
                        {
                            Console.WriteLine("You need a break, " + a + " poor grades.");
                            break;
                        }
                    }
                }
                lastproblem = problem;
                SM += evalution;
                count++;
            }
        }
    }
}
