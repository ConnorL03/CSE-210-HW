using System.IO; 

public class Journal
{
    Entry entry = new Entry();

    public List<Entry> _journalEntries = new List<Entry>();

    public void AddEntry()
    {
        string prompt = entry.GetPrompt();

        Console.WriteLine(prompt);
        Console.Write(">");
        string responce = Console.ReadLine();

        DateTime theCurrentDate = DateTime.Now;
        string dateText = theCurrentDate.ToShortDateString();

        entry._journalEntry = responce;
        entry._promptGiven = prompt;
        entry._dateOfEntry = dateText;

        _journalEntries.Add(entry);
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine("Here are your journal entiries: ");
        Console.WriteLine(">");
        foreach (Entry journalEntry in _journalEntries)
        {
            
            Console.WriteLine($"Date: {journalEntry._dateOfEntry} - Prompt: {journalEntry._promptGiven}");
            Console.WriteLine(journalEntry._journalEntry);
        }
        Console.WriteLine();
    }
    public void SaveToFile()
    {
        Console.WriteLine("What is your file name? ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _journalEntries)
            {
                outputFile.WriteLine($"{entry._dateOfEntry} ~|~ {entry._promptGiven} ~|~ {entry._journalEntry}");
            }
        }
        Console.WriteLine($"All entries saved have been saved to {fileName}");
    }

    public void LoadFromFile()
    {
        Console.Write("What is the name of the file you want to load from? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        Console.WriteLine($"Number of lines: {lines.Length}");

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            Entry newEntry = new Entry();

            newEntry._dateOfEntry = parts[0];
            newEntry._promptGiven = parts[1];
            newEntry._journalEntry = parts[2];

            _journalEntries.Add(newEntry);
        }

    }    
    
}

