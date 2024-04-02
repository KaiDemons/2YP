using System;

class Numbers
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }

    public void PrintNumbers()
    {
        Console.WriteLine($"Number 1: {Number1}");
        Console.WriteLine($"Number 2: {Number2}");
    }
    public void ChangeNumbers(int newNumber1, int newNumber2)
    {
        Number1 = newNumber1;
        Number2 = newNumber2;
    }

    public int SumOfNumbers()
    {
        return Number1 + Number2;
    }

    public int MaxNumber()
    {
        return Math.Max(Number1, Number2);
    }

    static void Main()
    {
        Numbers numbers = new Numbers();
        numbers.ChangeNumbers(6, 26);
        
        Console.WriteLine("Initial Numbers:");
        numbers.PrintNumbers();
        Console.WriteLine($"Sum of Numbers: {numbers.SumOfNumbers()}");
        Console.WriteLine($"Max Number: {numbers.MaxNumber()}");

        numbers.ChangeNumbers(7, 22);
        
        Console.WriteLine("\nUpdated Numbers:");
        numbers.PrintNumbers();
        Console.WriteLine($"Sum of Numbers: {numbers.SumOfNumbers()}");
        Console.WriteLine($"Max Number: {numbers.MaxNumber()}");
    }
}


