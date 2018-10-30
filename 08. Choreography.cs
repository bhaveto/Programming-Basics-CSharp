using System;


namespace _08.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberStep = double.Parse(Console.ReadLine());
            double numberDancer = double.Parse(Console.ReadLine());
            double numberDays = double.Parse(Console.ReadLine());

            double stepPerDay = Math.Ceiling(((numberStep / numberDays) / numberStep)*100);
            double stepPerDancer = (stepPerDay / numberDancer);
            
            if (stepPerDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepPerDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepPerDancer:f2}% steps to be learned per day.");
            }
            
        }
    }
}
