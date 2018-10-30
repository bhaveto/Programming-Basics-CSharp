using System;
namespace alcoholMarket
{
    class alcoholMarket
    {
        static void Main(string[] args)
        {
            double wLv = double.Parse(Console.ReadLine());
            double bLit = double.Parse(Console.ReadLine());
            double wineLit = double.Parse(Console.ReadLine());
            double rLit = double.Parse(Console.ReadLine());
            double wLit = double.Parse(Console.ReadLine());
            double rPrice = wLv / 2;
            double winePrice = rPrice * 0.6;
            double beerPrice = rPrice * 0.2;
            double sumWhiskey = wLv * wLit;
            double sumBeer = bLit * beerPrice;
            double sumWine = wineLit * winePrice;
            double sumRakia = rLit * rPrice;
            double sumAll = sumWhiskey + sumBeer + sumWine + sumRakia;
            Console.WriteLine("{0:f2}", sumAll);

        }
    }
}