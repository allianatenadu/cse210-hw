using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        string letterGrade = "";
        string sign = "";

        // Determine the base letter grade
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Stretch Challenge: Add "+" or "-" sign (excluding A+ and F signs)
        int lastDigit = gradePercentage % 10;

        if (letterGrade != "A" && letterGrade != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letterGrade == "A" && lastDigit < 3)
        {
            sign = "-";
        }

        // Display the letter grade with sign
        Console.WriteLine($"\nYour grade is: {letterGrade}{sign}");

        // Pass or fail message
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep working hard and you'll improve next time.");
        }
    }
}