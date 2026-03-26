using System;
using Calculator.Exceptions;
using Calculator.Interface;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculatorOperations calc = new CalculatorOperations();

            try
            {
                Console.Write("Enter 1st Integer : ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Enter 2nd Integer : ");
                int b = Convert.ToInt32(Console.ReadLine());

                if (b == 0)
                {
                    throw new InvalidInput("2nd Integer cannot be zero.");
                }

                Console.WriteLine();

                Console.WriteLine("Results : ");
                Console.WriteLine();
                Console.WriteLine($"Addition : {calc.Add(a, b)}");
                Console.WriteLine($"Subtraction : {calc.Sub(a, b)}");
                Console.WriteLine($"Multiplication : {calc.Mul(a, b)}");
                Console.WriteLine($"Division : {calc.Div(a, b):N3}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}