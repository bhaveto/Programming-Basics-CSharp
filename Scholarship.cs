using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double avSucces = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double stipendSoc = Math.Floor(minSalary * 0.35);
            double stipendSucc = Math.Floor(avSucces * 25);

            if (avSucces > 4.5 && avSucces < 5.5 && income < minSalary)
            {
                Console.WriteLine($"You get a Social scholarship {stipendSoc} BGN");
            }
            else if (avSucces >= 5.50 && income > minSalary)
            {
                Console.WriteLine($"You get a scholarship for excellent results {stipendSucc} BGN");
            }
            else if (avSucces >= 5.50 && income <= minSalary)
            {
                if (stipendSoc > stipendSucc)
                {
                    Console.WriteLine($"You get a Social scholarship {stipendSoc} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {stipendSucc} BGN");
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}