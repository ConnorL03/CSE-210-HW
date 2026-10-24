using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        Scripture _scripture = null;

        // Exciding requirerments
        
       
       Console.WriteLine("Which scripture do you want to memorize?");
       Console.WriteLine("Type '1' for Proverbs 3: 5-6");
       Console.WriteLine("Type '2' for 3 Nephi 5: 13");
       Console.WriteLine("Type '3' for Alma 7: 13-14");
       Console.WriteLine("Type '4' to enter your own scripture! ");
       Console.Write("Type choise here: ");
       int choice = int.Parse(Console.ReadLine());


       if (choice == 1)
        {
        int chapter = 3;
        string book = "Proverbs";
        int start = 5;
        int end = 6;
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        _scripture = new Scripture(scriptureText, chapter, book, start, end);
        }

        if (choice == 2)
        {
        int chapter = 5;
        string book = "3 Nephi";
        int start = 13;
        string scriptureText = "Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life.";

        _scripture = new Scripture(scriptureText, chapter, book, start);
        }

        if (choice == 3)
        {
        int chapter = 7;
        string book = "Alma";
        int start = 13;
        string scriptureText = "Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me."; 

        _scripture = new Scripture(scriptureText, chapter, book, start);
        }

        if (choice == 4)
        {
            Console.Write("Enter the book of your scripture: ");
            string book = Console.ReadLine();

            Console.Write("Enter the chapter: ");
            int chapter = int.Parse(Console.ReadLine());

            Console.Write("Does your scripture only have one verse? ");
            string oneVerse = Console.ReadLine();

            if (oneVerse == "yes")
            {
                Console.Write("What is your verse number? ");
                int start = int.Parse(Console.ReadLine());

                Console.Write("Type out your verse here: ");
                string scriptureText = Console.ReadLine();
                _scripture = new Scripture(scriptureText, chapter, book, start);
            }
            else if (oneVerse == "no")
            {
                Console.Write("What is the number of your first verse? ");
                int start = int.Parse(Console.ReadLine());

                Console.Write("What is the number of your last verse? ");
                int end = int.Parse(Console.ReadLine());

                Console.Write("Type out your verse here (you can use verse numbers): ");
                string scriptureText = Console.ReadLine();
                _scripture = new Scripture(scriptureText, chapter, book, start, end);
            }
        }
        

        Console.Clear();

        // these are my two conditions that keep the while loop running
        string keyWord1;
        string keyWord2;

        do
        {
            _scripture.GetRenderedText();

            // here we check condition 1
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            keyWord1 = Console.ReadLine();

            // Here we clear the console and hide three words.
            // Then if the user has not quit the loop will restart and print the new rendered text
            
            _scripture.Hide3Words();

            // here we check to make sure the scripture is not completely 
            keyWord2 = _scripture.IsCompletelyHidden();

            Console.Clear();


        } while (keyWord1 != "quit" && keyWord2 != "quit");
    }

}