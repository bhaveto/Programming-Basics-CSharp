using System;
namespace _02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double lastNum = Math.Abs(num % 10);
            int bonusPoint1 = 5;
            double bonusPoint2 = num * 0.2;
            double bonusPoint3 = num * 0.10;
            double sumBonusPoint = 0;
            if (num <= 100)
            {
                sumBonusPoint = bonusPoint1;
            }
            else if (num < 1000)
            {
                sumBonusPoint = bonusPoint2;
            }
            else if (num > 1000)
            {
                sumBonusPoint = bonusPoint3;
            }
            if (num % 2 == 0)
            {
                sumBonusPoint = sumBonusPoint + 1;
            }
            if (lastNum == 5)
            {
                sumBonusPoint = sumBonusPoint + 2;
            }
            Console.WriteLine(sumBonusPoint);
            Console.WriteLine(num + sumBonusPoint);
        }
    }
}
