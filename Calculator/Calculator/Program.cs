using System;

public interface ICalculatorOperations
{
    int Add(int a, int b);
    int Sub(int a, int b);
    int Mul(int a, int b);
    double Div(int a, int b);
}

public class CalculatorOperations : ICalculatorOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Sub(int a, int b)
    {
        return a - b;
    }
    public int Mul(int a, int b)
    {
        return a * b;
    }
    public double Div(int a, int b)
    {
        return (double)a / b;
    }
}

class InvalidInput : Exception
{
    public InvalidInput(string msg) : base(msg) { }
}

class Program
{
    public static void Main(string[] args)
    {
        CalculatorOperations calc = new CalculatorOperations();

        try
        {
            Console.Write("Enter 1st Integer : ");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a < 0)
            {
                throw new InvalidInput("1st Integer cannot be less than zero.");
            }

            Console.WriteLine();

            Console.Write("Enter 2nd Integer : ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(b < 0)
            {
                throw new InvalidInput("2nd Integer cannot be less than zero.");
            }

            Console.WriteLine();

            int add = calc.Add(a, b);
            int sub = calc.Sub(a, b);
            int mul = calc.Mul(a, b);
            double divide = calc.Div(a, b);

            Console.WriteLine("Results : ");
            Console.WriteLine();
            Console.WriteLine($"Addition : {add}");
            Console.WriteLine($"Subtraction : {sub}");
            Console.WriteLine($"Multiplication : {mul}");
            Console.WriteLine($"Division : {divide:N3}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}