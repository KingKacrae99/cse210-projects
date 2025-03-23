using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(5);
        Fraction fraction2 = new Fraction(3,4);

        // getter and setter methods
        fraction2.GetTop();
        fraction2.GetBottom();
        string fractionValue = fraction2.GetFractionString();
        double answer = fraction2.GetDecimalValue();
        Console.WriteLine($"fraction: {fractionValue}");
        Console.WriteLine($"Result: {answer}");

        
    }
}