public class Reference
{
    private int _chapter;
    private string _book;
    private int _startingVerse;
    private int? _endingVerse;
    public Reference(int chapter, string book, int verse)
    {
        _chapter = chapter;
        _book = book;
        _startingVerse = verse;
        _endingVerse = null;
    } 
    public Reference (int chapter, string book, int startVerse, int endVerse)
    {
        _chapter = chapter;
        _book = book;
        _startingVerse = startVerse;
        _endingVerse = endVerse;
    }

    public void DisplayReference()
    {
        if(_endingVerse == null)
        {
            Console.WriteLine($"{_book} {_chapter}: {_startingVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_startingVerse}-{_endingVerse}");
        }
    }
}
