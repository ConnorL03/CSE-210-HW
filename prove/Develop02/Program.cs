using System;
using System.IO.Enumeration;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        // Declaring my choice variable and my list that will me used throughout the program
        int choice = 0; 
        
        Journal journalEntry = new Journal();
        Console.WriteLine("Welsome to the Journal Program! ");
        do
        {
            Console.WriteLine("Please selsct one of the following choises: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Save ");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Quit ");

            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                journalEntry.AddEntry();
            }

            else if (choice == 2)
            {
                journalEntry.Display();
            }

            else if (choice == 3)
            {
                journalEntry.SaveToFile();
            }

            else if (choice == 4)
            {
                journalEntry.LoadFromFile();
            }

        } while (choice != 5);



    }
}