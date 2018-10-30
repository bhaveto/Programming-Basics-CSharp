using System;
namespace tailoringWorkshop
{
    class tailoringWorkshop
    {
        static void Main(string[] args)
        {
            int table = int.Parse(Console.ReadLine());
            double rectangleTable = double.Parse(Console.ReadLine());
            double rectangularTable = double.Parse(Console.ReadLine());
            if (table > 1 && table <= 500 && rectangleTable > 0.00 && rectangleTable <= 3.00 && rectangularTable > 0.00 && rectangularTable <= 3.00)
            {
                var all = table * (rectangleTable + 2 * 0.3) * (rectangularTable + 2 * 0.3);
                var care = table * (rectangleTable / 2) * (rectangleTable / 2);
                var resul1 = (all * 7) + (care * 9);
                var resul2 = (((all * 7) + (care * 9)) * 1.85);
                Console.Write("{0:f2}", resul1);
                Console.WriteLine(" USD");
                Console.Write("{0:f2}", resul2);
                Console.WriteLine(" BGN");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}