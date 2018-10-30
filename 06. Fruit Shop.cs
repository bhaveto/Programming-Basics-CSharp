using System;
namespace _06.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double banana = Math.Abs(quantity * 2.50);
            double apple = Math.Abs(quantity * 1.20);
            double orange = Math.Abs(quantity * 0.85);
            double grapefruit = Math.Abs(quantity * 1.45);
            double kiwi = Math.Abs(quantity * 2.70);
            double pineapple = Math.Abs(quantity * 5.50);
            double grapes = Math.Abs(quantity * 3.85);

            double bananaWeek = Math.Abs(quantity * 2.70);
            double appleWeek = Math.Abs(quantity * 1.25);
            double orangeWeek = Math.Abs(quantity * 0.90);
            double grapefruitWeek = Math.Abs(quantity * 1.60);
            double kiwiWeek = Math.Abs(quantity * 3.00);
            double pineappleWeek = Math.Abs(quantity * 5.60);
            double grapesWeek = Math.Abs(quantity * 4.20);

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{banana:f2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{apple:f2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{orange:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{grapefruit:f2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{kiwi:f2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{pineapple:f2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{grapes:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{bananaWeek:f2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{appleWeek:f2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{orangeWeek:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{grapefruitWeek:f2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{kiwiWeek:f2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{pineappleWeek:f2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{grapesWeek:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }   
    }
}
