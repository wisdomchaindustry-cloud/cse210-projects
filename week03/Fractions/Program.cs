using System;

class Program
{
    static void Main(string[] args)
    {
        // Using first constructor
        Fraction frac1 = new Fraction();

        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        // Using second constructor
        Fraction frac2 = new Fraction(5);

        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        // Using third constructor
        Fraction frac3 = new Fraction(3, 4);

        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        Fraction frac4 = new Fraction(1, 3);

        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());

        // Testing getters and setters
        Fraction frac5 = new Fraction();

        frac5.SetTop(6);
        frac5.SetBottom(7);

        Console.WriteLine(frac5.GetFractionString());
        Console.WriteLine(frac5.GetDecimalValue());
    }
}