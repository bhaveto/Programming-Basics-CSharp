using System;
namespace ExcellentResult
{
    class excellentResult
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if(num >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}