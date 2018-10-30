using System;
namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();

            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "carrot":
                case "pepper":
                case "cucumber":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknow");
                    break;

            }
            
        }
    }
}
