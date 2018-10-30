using System;
namespace _08.Journey1
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seasson = Console.ReadLine().ToLower();

            double campPrice = 0.00;
            double hotelPrice = 0.00;
            bool vacInBulgaria = budget <= 100;
            bool vacInBalkans = budget <= 1000;
            bool vacInEurope = budget > 1000;

            if (vacInBulgaria == true && seasson == "summer")
            {
                campPrice = budget * 0.30;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine($"Camp - {campPrice:f2}");
            }
            else if(vacInBulgaria == true && seasson == "winter")
            {
                hotelPrice = budget * 0.70;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine($"Hotel - {hotelPrice:f2}");
            }
            else if(vacInBalkans == true && seasson == "summer")
            {
                campPrice = budget * 0.40;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine($"Camp - {campPrice:f2}");
            }
            else if (vacInBalkans == true && seasson == "winter")
            {
                hotelPrice = budget * 0.80;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine($"Hotel - {hotelPrice:f2}");
            }
            else if (vacInEurope == true && seasson == "summer" || seasson == "winter")
            {
                hotelPrice = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {hotelPrice:f2}");
            }
        }
    }
}
