using System;

class Program
{
    // // Helper method for safe number entry
    static int GetValidGrade(string prompt)
    {
        int grade;
        bool isValid = false;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();


            if (int.TryParse(input, out grade))
            {
                // 2. Grade Range Verification (0-100 check)
                if (grade >= 0 && grade <= 100)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid numeric value.");
            }
        } while (!isValid);

        return grade;
    }

    static void Main(string[] args)
    {
        Console.Write("Please enter your name and surname: ");
        string nameSurname = Console.ReadLine() ?? "Guest";

        Console.WriteLine($"\nHello, {nameSurname}!");
        Console.WriteLine("Welcome to the C# programming world.");
        Console.WriteLine("We will calculate the letter grade with you today.");
        Console.WriteLine("Then let's get started right away.\n");


        int firstExamGrade = GetValidGrade("Please enter your first exam grade: ");
        int secondExamGrade = GetValidGrade("Please enter your second exam grade: ");
        int finalProjectGrade = GetValidGrade("Your final project Grade: ");


        double averageGrade = (firstExamGrade + secondExamGrade + finalProjectGrade) / 3.0;

        string letterGrade;

        if (averageGrade < 50)
        {
            letterGrade = "FF";
        }
        else if (averageGrade < 60)
        {
            letterGrade = "DD";
        }
        else if (averageGrade < 70)
        {
            letterGrade = "CC";
        }
        else if (averageGrade < 80)
        {
            letterGrade = "BB";
        }
        else
        {
            letterGrade = "AA";
        }

        Console.WriteLine($"\nYour average grade is: {averageGrade:F2}");
        Console.WriteLine($"Your letter grade is: {letterGrade}");

        Console.WriteLine($"\nHave a nice day, see you again {nameSurname}!");
    }
}