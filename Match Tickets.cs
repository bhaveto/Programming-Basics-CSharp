using System;
namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            int numPeople = int.Parse(Console.ReadLine());

            double ticketVip = numPeople * 499.99;
            double ticketNor = numPeople * 249.99;
            double theirBudget = 0.00;

            if(numPeople >= 1 && numPeople <=4)
            {
                theirBudget = budget - (budget * 0.75);
            }
            else if(numPeople >= 5 && numPeople <= 9)
            {
                theirBudget = budget - (budget * 0.60);
            }
            else if (numPeople >= 10 && numPeople <= 24)
            {
                theirBudget = budget - (budget * 0.50);
            }
            else if (numPeople >= 25 && numPeople <= 49)
            {
                theirBudget = budget - (budget * 0.40);
            }
            else if (numPeople >= 50)
            {
                theirBudget = budget - (budget * 0.25);
            }
            if(type == "vip")
            {
                if(theirBudget >= ticketVip)
                {
                    double freeMoney = theirBudget - ticketVip;
                    Console.WriteLine($"Yes! You have {freeMoney:f2} leva left.");
                }
                else
                {
                    double noMoney = ticketVip - theirBudget;
                    Console.WriteLine($"Not enough money! You need {noMoney:f2} leva.");
                }
            }
            else if(type == "normal")
            {
                if(theirBudget >= ticketNor)
                {
                    double freeMoney = theirBudget - ticketNor;
                    Console.WriteLine($"Yes! You have {freeMoney:f2} leva left.");
                }
                else
                {
                    double noMoney = ticketNor - theirBudget;
                    Console.WriteLine($"Not enough money! You need {noMoney:f2} leva.");
                }
            }
            
        }
    }
}
