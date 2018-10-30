using System;
namespace _10.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int numbNight = int.Parse(Console.ReadLine());

            double discountStudio = 1.00;
            double discountApartment = 1.00;
            double priceStudio = 0.00;
            double priceApartment = 0.00;

            switch (month)
            {
                case "may":
                case "october":
                    priceStudio = 50.00;
                    priceApartment = 65.00;
                    if (numbNight > 7 && numbNight <= 14)
                    {
                        discountStudio = 0.95;
                    }
                    else if (numbNight > 14)
                    {
                        discountStudio = 0.70;
                        discountApartment = 0.90;
                    }
                    break;
                case "june":
                case "september":
                    priceStudio = 75.20;
                    priceApartment = 68.70;
                    if(numbNight > 14)
                    {
                        discountStudio = 0.80;
                        discountApartment = 0.90;
                    }
                    break;
                case "july":
                case "august":
                    priceStudio = 76.00;
                    priceApartment = 77.00;
                    if(numbNight > 14)
                    {
                        discountApartment = 0.90;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {(numbNight * priceApartment) * discountApartment:f2} lv.");
            Console.WriteLine($"Studio: {(numbNight * priceStudio) * discountStudio:f2} lv.");
            }
        }
    }
