using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers,type 0 when finished");

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number : ");
            userNumber = int.Parse(Console.ReadLine() !);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //finding sum

        int sum = 0;
        foreach (int number in numbers)
        {
            sum+= number;
        }

        // finding Average

        double average = (double)sum / numbers.Count;

        // How to find largest number

        int largestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largestNumber}");
    }

}