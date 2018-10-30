using System;

public class Program
{
    public static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int totalMinutes = hours * 60 + minutes + 15;
        minutes = totalMinutes % 60;
        hours = totalMinutes / 60;
        if (hours >= 24)
        {
            Console.WriteLine($"0:{minutes:D2}");
        }
        else
        {
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}