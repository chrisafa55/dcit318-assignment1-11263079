using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter a numerical grade (0 - 100): ");
        int grade;

        // Validate input
        if (int.TryParse(Console.ReadLine(), out grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
            else
            {
                char letterGrade;

                if (grade >= 90)
                    letterGrade = 'A';
                else if (grade >= 80)
                    letterGrade = 'B';
                else if (grade >= 70)
                    letterGrade = 'C';
                else if (grade >= 60)
                    letterGrade = 'D';
                else
                    letterGrade = 'F';

                Console.WriteLine($"Your letter grade is: {letterGrade}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}

