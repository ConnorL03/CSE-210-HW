public class ReflectionActivity : Activity
{
    public ReflectionActivity(string title, string intro, int duration, string outro) : base (title, intro, duration, outro)
    {


    }
    public void InteractReflectionActivity()
    {
        List<string> reflectionStatements =  new List<string>
        {
            
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."

        };
        
        List<string> reflectionQuestions = new List<string>
        {

        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"

        };


       ShowIntro();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Random random = new Random();
        int index = random.Next(reflectionStatements.Count);
        Console.WriteLine($"---{reflectionStatements[index]} ---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        
        Console.Clear();

        Console.WriteLine("Now ponder on each of the following questions as they realted to this experience.");

        Console.Write("You may begin in ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.Clear();

        DateTime startime = DateTime.Now;
        DateTime endtime = startime.AddSeconds(_duration);
        while(DateTime.Now < endtime)
        {
        int index2 = random.Next(reflectionQuestions.Count);
        Console.Write($"> {reflectionQuestions[index2]}");
        ShowSpinner();
        ShowSpinner();
        ShowSpinner();
        Console.WriteLine();
        }

        ShowEpilogue();
        

    }
}