using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            double bonusPoints = 0;

            if (points <= 100)
            {
                bonusPoints = 5;
            }

            else if (points > 1000)
            {
                bonusPoints = 0.1 * points;
            }

            else
            {
                bonusPoints = 0.2 * points;
            }

            if (points % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }

            else if (points % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }

            double totalPoints = points + bonusPoints;

            Console.WriteLine(bonusPoints);
            Console.WriteLine(totalPoints);

        }
    }
}
