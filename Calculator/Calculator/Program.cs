using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Type a number and press enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type another number and press enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Division");
            Console.Write("Your option?");

            switch(Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    if(num2 != 0)
                    {
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    }
                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();

        }
    }
}
