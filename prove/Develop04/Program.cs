using System;

class Program
{
    static void Main(string[] args)
    {
        
        int choice = 0;
        while(choice!= 4)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfullness App!");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choise from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
               string title = "Breathing Activity";
               Console.WriteLine($"Welcome to the {title}.");
               string intro = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."; 
               Console.WriteLine(intro);
               Console.WriteLine();
               Console.Write("How long, in seconds, would you like this activity to last? ");
               int duration = int.Parse(Console.ReadLine()); 
               string outro = $"You have completed another {duration} seconds of the {title}.";
               BreathingActivity breathingActivity = new BreathingActivity (title, intro, duration, outro);
               Console.Clear();

               breathingActivity.InteractBreathingActivity(); 
            }
            else if (choice == 2)
            {
                Console.Clear();
                string title = "Reflecting Activity";
                Console.WriteLine($"Welcome to the {title}.");
                Console.WriteLine();
                string intro = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Console.WriteLine(intro);
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like this activity to last? ");
                int duration = int.Parse(Console.ReadLine()); 
                string outro = $"You have completed another {duration} seconds of the {title}.";
                ReflectionActivity reflectingActivity = new ReflectionActivity (title, intro, duration, outro);
                Console.Clear();

                reflectingActivity.InteractReflectionActivity();
            }
            else if (choice == 3)
            {
                Console.Clear();
                string title = "Listing Activity";
                Console.WriteLine($"Welcome to the {title}.");
                Console.WriteLine();
                string intro = "This activity will help you reflect on the good things in your life by having you list as may things as you can in a cerListing";
                Console.WriteLine(intro);
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like this activity to last? ");
                int duration = int.Parse(Console.ReadLine()); 
                string outro = $"You have completed another {duration} seconds of the {title}.";
                ListingActivity listingActivity = new ListingActivity (title, intro, duration, outro);
                Console.Clear();
                
                listingActivity.InteractListingActivity();
            }
        }
    }
}