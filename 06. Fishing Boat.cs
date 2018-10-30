using System;
namespace _06.Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
namespace _06.Fishing_Boat
    {
        class Program
        {
            static void Main(string[] args)
            {
                int budgetGroup = int.Parse(Console.ReadLine());
                string season = Console.ReadLine().ToLower();
                int numbFishermen = int.Parse(Console.ReadLine());

                double shipRentSpring = 3000.00;
                double shipRentSummer = 4200.00;
                double shipRentAutumn = 4200.00;
                double shipRentWinter = 2600.00;
                double sumPay = 0.00;

                if (season == "spring")
                {
                    if (numbFishermen >= 1 && numbFishermen <= 6)
                    {
                        if (numbFishermen % 2 == 0)
                        {
                            sumPay = shipRentSpring * 0.9;
                            sumPay -= sumPay * 0.05;
                        }
                        else
                        {
                            sumPay = shipRentSpring * 0.90;
                        }
                    }

                    else if (numbFishermen >= 7 && numbFishermen <= 11)
                    {
                        if (numbFishermen % 2 == 0)
                        {
                            sumPay = shipRentSpring * 0.85;
                            sumPay -= sumPay * 0.05;
                        }
                        else
                        {
                            sumPay = shipRentSpring * 0.85;
                        }
                    }
                    else if (numbFishermen >= 12)
                    {
                        if (numbFishermen % 2 == 0)
                        {
                            sumPay = shipRentSpring * 0.75;
                            sumPay -= sumPay * 0.05;
                        }
                        else
                        {
                            sumPay = shipRentSpring * 0.75;
                        }
                    }
                }
                else if (season == "summer")
                {
                    if (numbFishermen >= 1 && numbFishermen <= 6)
                    {
                        if (numbFishermen % 2 == 0)
                        {
                            sumPay = shipRentSummer * 0.90;
                            sumPay -= sumPay * 0.05;
                        }
                        else
                        {
                            sumPay = shipRentSummer * 0.90;
                        }
                    }
                    else if (numbFishermen >= 7 && numbFishermen <= 11)
                    {
                        if (numbFishermen % 2 == 0)
                        {
                            sumPay = shipRentSummer * 0.85;
                            sumPay -= sumPay * 0.05;
                        }
                        else
                        {
                            sumPay = shipRentSummer * 0.85;
                        }
                    }
                    else if (numbFishermen >= 12)
                    {
                        if (numbFishermen % 2 == 0)
                        {
                            sumPay = shipRentSummer * 0.75;
                            sumPay -= sumPay * 0.05;
                        }
                        else
                        {
                            sumPay = shipRentSummer * 0.75;
                        }
                    }
                }
                else if (season == "winter")
                {
                    if (numbFishermen >= 1 && numbFishermen <= 6)
                    {
                        if (numbFishermen % 2 == 0)
                        {
                            sumPay = shipRentWinter * 0.90;
                            sumPay -= sumPay * 0.05;
                        }
                        else
                        {
                            sumPay = shipRentWinter * 0.90;
                        }
                    }
                    else if (numbFishermen >= 7 && numbFishermen <= 11)
                    {
                        if (numbFishermen % 2 == 0)
                        {
                            sumPay = shipRentWinter * 0.85;
                            sumPay -= sumPay * 0.05;
                        }
                        else
                        {
                            sumPay = shipRentWinter * 0.85;
                        }
                    }
                    else if (numbFishermen >= 12)
                    {
                        if (numbFishermen % 2 == 0)
                        {
                            sumPay = shipRentWinter * 0.75;
                            sumPay -= sumPay * 0.05;
                        }
                        else
                        {
                            sumPay = shipRentWinter * 0.75;
                        }
                    }
                }
                else if (season == "autumn")
                {
                    if (numbFishermen >= 1 && numbFishermen <= 6)
                    {
                        sumPay = shipRentAutumn * 0.90;
                    }
                    else if (numbFishermen >= 7 && numbFishermen <= 11)
                    {
                        sumPay = shipRentAutumn * 0.85;
                    }
                    else if (numbFishermen >= 12)
                    {
                        sumPay = shipRentAutumn * 0.75;
                    }
                }

                if (budgetGroup >= sumPay)
                {
                    double finalSum = budgetGroup - sumPay;
                    Console.WriteLine($"Yes! You have {finalSum:f2} leva left.");
                }
                else
                {
                    double finalSum = sumPay - budgetGroup;
                    Console.WriteLine($"Not enough money! You need {finalSum:f2} leva.");
                }
            }
        }
    }

}
    }
}
