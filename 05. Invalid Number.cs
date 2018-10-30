using System;
namespace _05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if ((x >= 100 && x <= 200) || x == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
