using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double spiritsQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double spiritsPrice = whiskeyPrice * 0.5;
            double winePrice = spiritsPrice - (spiritsPrice * 0.4);
            double beerPrice = spiritsPrice - (spiritsPrice * 0.8);

            double spiritsSum = spiritsQuantity * spiritsPrice;
            double wineSum = wineQuantity * winePrice;
            double beerSum = beerQuantity * beerPrice;
            double whiskeySum = whiskeyQuantity * whiskeyPrice;

            double total = whiskeySum + spiritsSum + wineSum + beerSum;

            Console.WriteLine("{0:F2}", total);
        }
    }
}
