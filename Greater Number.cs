using System;
namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"The biggest number is: {a}");
            }
            else
            {
                Console.WriteLine($"The biggest number is: {b}");
            }
        }
    }
}
