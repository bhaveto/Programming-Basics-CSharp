using System;
namespace SumSeconds
{
    class Seconds
    {
        static void Main(string[] args)
        {
            double racerOne = double.Parse(Console.ReadLine());
            double racerTwo = double.Parse(Console.ReadLine());
            double racerThree = double.Parse(Console.ReadLine());

            double totalTime = racerOne + racerTwo + racerThree;
            if (totalTime < 10)
            {
                Console.WriteLine($"0:0{totalTime}");
            }
            else if (totalTime <= 59)
            {
                Console.WriteLine($"0:{totalTime}");
            }
            else if (totalTime >= 60 && totalTime <= 119)
            {
                double timeInSeconds = totalTime - 60;
                Console.WriteLine($"1:{timeInSeconds:00}");
            }
            else if (totalTime >= 120 && totalTime <= 179)
            {
                double timeInSeconds = totalTime - 120;
                Console.WriteLine($"2:{timeInSeconds:00}");
            }
        }
    }
}