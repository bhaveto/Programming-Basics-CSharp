using System;
namespace Even_Or_Odd
{
    class even
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            var b = a % 2;
            if (b == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}