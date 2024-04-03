using System;

class Calculation
{
    public string CalculationLine { get; private set; }

    public void SetCalculationLine(string newLine)
    {
        CalculationLine = newLine;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        CalculationLine += symbol;
    }

    public void GetCalculationLine()
    {
        Console.WriteLine($"Calculation Line: {CalculationLine}");
    }

    public char GetLastSymbol()
    {
        return CalculationLine[^1];
    }

    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(CalculationLine))
        {
            CalculationLine = CalculationLine.Substring(0, CalculationLine.Length - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();
        calc.SetCalculationLine("2 + 3 * 4 ");

        calc.GetCalculationLine();

        calc.SetLastSymbolCalculationLine('=');
        calc.GetCalculationLine(); 

        Console.WriteLine($"Last Symbol: {calc.GetLastSymbol()}"); 

        calc.DeleteLastSymbol();
        calc.GetCalculationLine(); 
    }
}