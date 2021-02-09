using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gof = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakePrice = cakes * 45;
            double gofPrice = gof * 5.80;
            double pancakePrice = pancakes * 3.20;

            double dayAmount = (cakePrice + gofPrice + pancakePrice) * confectioners;
            double campainAmount = dayAmount * days;

            double amountDisposable = campainAmount - (campainAmount / 8);

            Console.WriteLine("{0:F2}", amountDisposable);
        }
    }
}
