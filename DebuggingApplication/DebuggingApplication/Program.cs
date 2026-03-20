using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter String : ");
        string userResponse = Console.ReadLine();

        if (Convert.ToBoolean(int.Parse(userResponse)))
        {

            Console.WriteLine("The entered value is a integer");

        }
    }
}