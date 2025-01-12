using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();
        int input;

        // Step 1: Ask the user for numbers and add them to the list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input == 0)
                break;  // Stop when the user enters 0

            numbers.Add(input);  // Add the number to the list
        }

        // Step 2: Calculate the sum, average, and largest number
        int sum = 0;
        int max = numbers[0];
        
        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
                max = number;
        }

        double average = (double)sum / numbers.Count;

        // Step 3: Output the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge (Optional):
        // 1. Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
                smallestPositive = number;
        }
        if (smallestPositive != int.MaxValue)
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        else
            Console.WriteLine("There are no positive numbers.");

        // 2. Sort the list and display it
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}