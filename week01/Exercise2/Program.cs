using System;

class Program
{
    static void Main(string[] args)
    {
        // 1) Ask the user for grade percentage
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        // 2) Determine letter grade using if / else if / else
        string letter;

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

        // Stretch: Determine + / - sign
        // Rule: + if last digit >= 7, - if last digit < 3, else no sign
        int lastDigit = grade % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // No A+ (only A or A-)
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        // No F+ or F- (only F)
        if (letter == "F")
        {
            sign = "";
        }

        // Print the final grade once
        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        // 3) Determine pass/fail (>= 70 passes)
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! You'll do better next time.");
        }
    }
}