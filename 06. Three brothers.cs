using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBro = double.Parse(Console.ReadLine());
            double secondBro = double.Parse(Console.ReadLine());
            double thirdBro = double.Parse(Console.ReadLine());
            double fatherTime = double.Parse(Console.ReadLine());
            double totalTime = 1 / (1 / firstBro + 1 / secondBro + 1 / thirdBro);
            double breakTime = (totalTime * 0.15) + totalTime;
            double surprise = fatherTime - breakTime;
            Console.WriteLine("Cleaning time: " + "{0:f2}", breakTime);
            if (surprise >= 0.00)
            {
                double surpriseYes = Math.Floor(surprise);
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.",surpriseYes);
            }
            else
            {
                surprise = Math.Abs(surprise);
                double surpriseNo = Math.Ceiling(surprise);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {surpriseNo} hours.");
            }
        }
    }
}
