using System;
namespace _09.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();

            double result = 0.00;
            string evenOrOdd = "";
           
            switch(sign)
            {
                case "+":
                    result = N1 + N2;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine(string.Format("{0} {1} {2} = {3} - {4}",N1,sign,N2,result,evenOrOdd));
                    break;
                case "-":
                    result = N1 - N2;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{N1} {sign} {N2} = {result} - {evenOrOdd}");
                    break;
                case "*":
                    result = N1 * N2;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", N1, sign, N2, result, evenOrOdd);
                    break;
                case "/":
                    result = N1 / N2;
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {sign} {N2} = {result:f2}");
                    }
                    break;
                case "%":
                    result = N1 % N2;
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {sign} {N2} = {result}");
                    }
                    break;
            }
        }
    }
}
//Ако операцията е модулно деление: 
//„{ N1} % {N2} = {остатък}“
//В случай на деление с 0(нула): 
//„Cannot divide { N1 }
//by zero“