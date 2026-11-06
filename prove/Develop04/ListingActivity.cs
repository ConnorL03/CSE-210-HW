public class ListingActivity : Activity
{
    

    public ListingActivity (string title, string intro, int duration, string outro) : base (title, intro, duration, outro)
    {
        
    }

    public void InteractListingActivity()
    {
        ShowIntro();
        List<string> ListingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"---{ListingPrompts[new Random().Next(ListingPrompts.Count)]}---");

        Console.Write("You may begin in:");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int itemCount = 0;

        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemCount++;
        }
        Console.WriteLine($"You have listed {itemCount} items!");

        ShowEpilogue();

    }
}