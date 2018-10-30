using System;
namespace danceHall
{
    class danceHall
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            if (L >= 10.00 && L <= 100.00 && W >= 10.00 && W <= 100.00 && A >= 2.00 && A <= 20.00)
            {
                double sRoom = L * W;
                double sWardrobe = A * A;
                double sBench = sRoom / 10;
                double sClean = sRoom - (sWardrobe + sBench);
                double dancer = sClean / 0.704;
                Console.WriteLine(Math.Floor(dancer));
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}