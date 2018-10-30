using System;
namespace _03.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            double numOfHolidays = double.Parse(Console.ReadLine());
            double numOfWeekForTravel = double.Parse(Console.ReadLine());

            double weekendInSofia = 48 - numOfWeekForTravel;
            double saturdayGameInSofia = weekendInSofia * (3.00 / 4);
            double gameInHolidays = numOfHolidays * (2.00 / 3);
            double allGames = saturdayGameInSofia + gameInHolidays + numOfWeekForTravel;
            if (year == "leap")
            {
                double leap = Math.Truncate(allGames + (allGames * 0.15));
                Console.WriteLine(leap);
            }
            else if(year == "normal")
            {
                Console.WriteLine(Math.Truncate(allGames));
            }

        }
    }
}
