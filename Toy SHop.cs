using System;

public class Program
{
    public static void Main()
    {
        double vacantionCost = double.Parse(Console.ReadLine());
        int puzzles = int.Parse(Console.ReadLine());
        int dolls = int.Parse(Console.ReadLine());
        int bears = int.Parse(Console.ReadLine());
        int minions = int.Parse(Console.ReadLine());
        int trucks = int.Parse(Console.ReadLine());

        double puzzlesPrice = puzzles * 2.6;
        double dollsPrice = dolls * 3;
        double bearsPrice = bears * 4.1;
        double minionsPrice = minions * 8.2;
        double trucksPrice = trucks * 2;

        double totalToys = puzzles + bears + minions + dolls + trucks;
        double totalPrice = puzzlesPrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;

        if (totalToys >= 50)
        {
            totalPrice = totalPrice - (totalPrice * 0.25);
        }

        totalPrice = totalPrice - (totalPrice * 0.10);

        if (totalPrice >= vacantionCost)
        {
            Console.WriteLine($"Yes! {totalPrice - vacantionCost:f2} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {vacantionCost - totalPrice:f2} lv needed.");
        }
    }
}