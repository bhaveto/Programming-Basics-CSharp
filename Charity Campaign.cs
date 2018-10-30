using System;
namespace charityCampaign
{
    class charityCampaign
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int cook = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int wafer = int.Parse(Console.ReadLine());
            int pancake = int.Parse(Console.ReadLine());
            double Cake = 45.00;
            double Wafer = 5.80;
            double Pancake = 3.20;
            if (day >= 0 && day <= 365 && cook >= 0 && cook <= 1000 && cake >= 0 && cake <= 2000 && wafer >= 0 && wafer <= 2000 && pancake >= 0 && pancake <= 2000)
            {
                var cakeSell = cake * Cake;
                var waferSell = wafer * Wafer;
                var pancakeSell = pancake * Pancake;
                var allSell = cakeSell + waferSell + pancakeSell;
                var daySell = allSell * cook;
                var allDaySell = daySell * day;
                Console.WriteLine("{0:f2}", allDaySell - (1 * allDaySell) / 8);

            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}