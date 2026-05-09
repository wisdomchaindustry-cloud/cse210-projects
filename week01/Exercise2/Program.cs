using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade in percentage: ");

        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        // Determination of grade

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";

        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determination of sign using last digit

        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else sign = "";

        //special cases
        if (letter == "A" && sign =="+")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        // final grade display

        Console.WriteLine($"Your grade is {letter}{sign}");

        // determination of pass of fail

        if ( grade >= 70)
        {
            Console.WriteLine("Congratulations!You passed the course");
        }
        else if(grade >= 60)
        {
            Console.WriteLine("You passed with a lower grade");
        }

        else
        {
            Console.WriteLine("Keep trying! You can do better next time");
        }

    }
}