public class Entry 
{
    public string _journalEntry = "";

    public string _dateOfEntry = "";

    public string _promptGiven = "";


    public string GetPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something I learned about myself today?",
            "What is one thing I accomplished today that I am proud of?",
            "What is something I wish more people understood about me?",
            "What is one thing that made me smile today?",
            "What is something I am looking forward to?",
            "Who has influenced my life the most today, and why?",
            "How did I help someone today?"

        };

        Random randomPrompt = new Random();
        int promptIndex = randomPrompt.Next( 0, prompts.Count);
        string prompt = prompts[promptIndex];

        return prompt;

    }

    

}
