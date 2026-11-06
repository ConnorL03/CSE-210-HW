using System.ComponentModel;
using System.Reflection;

public class BreathingActivity : Activity
{
    public BreathingActivity(string title, string intro, int duration, string outro) : base (title, intro, duration, outro)
    {


    }

    public void InteractBreathingActivity()
    {
        ShowIntro();

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }
            Console.WriteLine();
            Console.Write("Breathe out...");
            for(int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

       ShowEpilogue();

    } 

}

