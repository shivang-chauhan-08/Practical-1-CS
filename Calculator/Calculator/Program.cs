using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter 1st Integer : ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Enter 2nd Integer : ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        int add = a + b;
        int sub = a - b;
        int mul = a * b;
        double divide = Convert.ToDouble(a) / Convert.ToDouble(b);

        Console.WriteLine("Results : ");
        Console.WriteLine();
        Console.WriteLine($"Addition : {add}");
        Console.WriteLine($"Subtraction : {sub}");
        Console.WriteLine($"Multiplication : {mul}");
        Console.WriteLine($"Division : {divide}");
    }
}