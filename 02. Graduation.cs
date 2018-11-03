using System;
namespace Graduation
{
    class Program
    {
        static void Main(string[]args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double avgGrade = 0.00;

            while(grade <= 12)
            {
                double evaluation = double.Parse(Console.ReadLine());
                if(evaluation >= 4)
                {
                    grade++;
                    avgGrade += evaluation;
                }
            }
            Console.WriteLine($"{name} graduated. Average grade: {avgGrade/12:f2}");
        }
    }
}