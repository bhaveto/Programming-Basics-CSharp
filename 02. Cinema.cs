using System;
namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double premiereFull = (row * column) * 12.00;
            double normalFull = (row * column) * 7.50;
            double discountFull = (row * column) * 5.00;

            if(typeProjection == "premiere")
            {
                Console.WriteLine("{0:f2}"+" leva",premiereFull);
            }
            else if(typeProjection == "normal")
            {
                Console.WriteLine("{0:f2}" + " leva", normalFull);
            }
            else if(typeProjection == "discount")
            {
                Console.WriteLine("{0:f2}" + " leva", discountFull);
            }
        }
    }
}
