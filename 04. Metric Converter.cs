using System;
namespace _04.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string strFrom = Console.ReadLine();
            string strTo = Console.ReadLine();

            string m = "m";
            string mm = "mm";
            string cm = "cm";
            string mi = "mi";
            string inc = "in";
            string km = "km";
            string ft = "ft";
            string yd = "yd";

            double lenReady = 0;

            if (strFrom == m)
            {
                lenReady = num;
            }
            else if (strFrom == mm)
            {
                lenReady = num /1000;
            }
            else if (strFrom == cm)
            {
                lenReady = num /100;
            }
            else if (strFrom == mi)
            {
                lenReady = num / 0.000621371192;
            }
            else if (strFrom == inc)
            {
                lenReady = num / 39.3700787;

            }
            else if (strFrom == km)
            {
                lenReady = num / 0.001;

            }
            else if (strFrom == ft)
            {
                lenReady = num / 3.2808399;

            }
            else if (strFrom == yd)
            {
                lenReady = num / 1.0936133;
            }

            if (strTo == m)
            {
                lenReady = lenReady * 1;
            }
            else if (strTo == mm)
            {
                lenReady = lenReady * 1000;
            }
            else if (strTo == cm)
            {
                lenReady = lenReady * 100;
            }
            else if (strTo == mi)
            {
                lenReady = lenReady * 0.000621371192;
            }
            else if (strTo == inc)
            {
                lenReady = lenReady * 39.3700787;
            }
            else if (strTo == km)
            {
                lenReady = lenReady * 0.001;
            }
            else if (strTo == ft)
            {
                lenReady = lenReady * 3.2808399;
            }
            else if (strTo == yd)
            {
                lenReady = lenReady * 1.0936133;
            }
            Console.WriteLine($"{lenReady:f8}");
        }
    }
}
