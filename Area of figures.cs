using System;
namespace AreaOfFigures
{
    class areaFigures
    {
        static void Main(string[] args)
        {
            string sq = "square";
            string re = "rectangle";
            string ci = "circle";
            string tr = "triangle";
            string usVar = Console.ReadLine();
            string usPro = usVar.ToLower();
            if (sq == usPro)
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * a:f3}");
            }
            else if (re == usPro)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b:f3}");
            }
            else if(ci == usPro)
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * r * r:f3}");
            }
            else if(tr == usPro)
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(a*h)/2:f3}");
            }
        }
    }
}