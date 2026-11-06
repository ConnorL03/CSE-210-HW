public class Activity
{
    protected string _title;
    protected string _intro;
    protected int _duration;
    protected string _outro;

    public Activity (string title, string intro, int duration, string outro)
    {
        _title = title;
        _intro = intro;
        _duration = duration;
        _outro = outro;

    }
    public void ShowSpinner()
    {
        List<string> spinnerAnimation = new List<string>();
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("\\");
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerAnimation[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if(i >= spinnerAnimation.Count)
            {
                i = 0;
            }
        }



    }
    public void ShowEpilogue()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine(_outro);
        ShowSpinner();
    }

    public void ShowIntro()
    {
        Console.WriteLine("Get ready ...");
        ShowSpinner();
    }
}