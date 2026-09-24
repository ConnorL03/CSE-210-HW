using System;

class Program
{
    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static void PromptUserName (out string UserName)
    {
        Console.Write("Please enter your name: ");
        UserName = Console.ReadLine();
    }

    static void PromtUserNumber (out int FavoriteNumber)
    {
        Console.Write("Please enter your favorite number: ");
        FavoriteNumber = int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear (out int BirthYear)
    {
        Console.Write("Please enter the year you were born: ");
        BirthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber (int FavoriteNumber)
    {
        int NumSquared = (FavoriteNumber*FavoriteNumber);
        return NumSquared;
    }

    static void DisplayResult(string UserName, int NumSquared, int BirthYear)
    {
        Console.WriteLine($"{UserName}, your favorite number squared is {NumSquared} ");
        int Age = 2026 - BirthYear;
        Console.WriteLine($"{UserName}, you will turn {Age} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();

        string UserName;
        PromptUserName(out UserName);

        int FavoriteNumber;
        PromtUserNumber (out FavoriteNumber);

        int BirthYear;
        PromptUserBirthYear (out BirthYear);

        int NumSquared = SquareNumber (FavoriteNumber);

        DisplayResult (UserName, NumSquared, BirthYear);
        
    }
}