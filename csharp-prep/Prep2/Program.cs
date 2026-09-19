using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage in CSE 210? ");
        string grade_percent = Console.ReadLine ();
        int grade_num = int.Parse(grade_percent);
        string letter = "z";

        if (grade_num >= 90)
        {
            letter = "A";
        }
        
        else if (grade_num >= 80)
        {
            letter = "B";
        }

        else if (grade_num >= 70)
        {
            letter = "C";
        }

        else if (grade_num >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Congrats you have a {letter} in the class");

        if (grade_num >= 70)
        {
            Console.WriteLine("Congrats you are passing the class! Good Job!");
        }

        else
        {
            Console.WriteLine("You are not passing the class right now, keep turning things in to get your grade up!");
        }

    }
}