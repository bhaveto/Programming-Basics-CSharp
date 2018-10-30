using System;
namespace _09.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentRecordSeconds = double.Parse(Console.ReadLine());
            double lenghtMeter = double.Parse(Console.ReadLine());
            double timeInSecondsForMeter = double.Parse(Console.ReadLine());

            double ivanSwim = lenghtMeter * timeInSecondsForMeter;
            double ivanSwimRetard = Math.Floor(lenghtMeter / 15);
            double ivanSwimRetardSeconds = ivanSwimRetard * 12.50;
            double ivanTotalTime = ivanSwim + ivanSwimRetardSeconds;

            if (ivanTotalTime < currentRecordSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {ivanTotalTime:f2} seconds.");
            }
            else
            {
                double notEnoughSeconds = ivanTotalTime - currentRecordSeconds;
                Console.WriteLine($"No, he failed! He was {notEnoughSeconds:f2} seconds slower.");
            }
        }
    }
}
