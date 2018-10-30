using System;
namespace _05.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            double numbFlower = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double sum = 0;

            if(flower == "Roses" && numbFlower > 80)
            {
                sum = (numbFlower * 5.00)*0.90;
            }
            else if(flower == "Dahlias" && numbFlower > 90)
            {
                sum = (numbFlower * 3.80) * 0.85;
            }
            else if(flower == "Tulips" && numbFlower > 80)
            {
                sum = (numbFlower * 2.80) * 0.85;
            }
            else if(flower == "Narcissus" && numbFlower < 120)
            {
                sum = (numbFlower * 3.00) * 1.15;
            }
            else if(flower == "Gladiolus" && numbFlower < 80)
            {
                 sum = (numbFlower * 2.50) * 1.20;
            }
            if (flower == "Roses" && numbFlower <= 80)
            {
                sum = numbFlower * 5.00;
            }
            else if (flower == "Dahlias" && numbFlower <= 90)
            {
                sum = numbFlower * 3.80;
            }
            else if (flower == "Tulips" && numbFlower <= 80)
            {
                sum = numbFlower * 2.80;
            }
            else if (flower == "Narcissus" && numbFlower >= 120)
            {
                sum = numbFlower * 3.00;
            }
            else if (flower == "Gladiolus" && numbFlower >= 80)
            {
                sum = numbFlower * 2.50;
            }

            if (budget >= sum)
            {
                double remainingBudget = budget - sum;
                Console.WriteLine($"Hey, you have a great garden with {numbFlower} {flower} and {remainingBudget:f2} leva left.");
            }
            else
            {
                double remainingBudget = sum - budget;
                Console.WriteLine($"Not enough money, you need {remainingBudget:f2} leva more.");
            }

        }
    }
}
