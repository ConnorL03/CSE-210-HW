public class Scripture
{
    List<Word> _word = new List<Word>();
    private Reference _reference;

// two constructors
    public Scripture(string words, int chapter, string book, int verse )
    {
        string [] text = words.Split();

        for(int i = 0; i < text.Length; i++)
        {
            Word word = new Word(text[i]);
            _word.Add(word);
        }
        _reference = new Reference(chapter, book, verse);
    }
    public Scripture(string scripture, int chapter, string book, int start, int end )
    {
        string [] text = scripture.Split();

        for(int i = 0; i < text.Length; i++)
        {
            Word word = new Word(text[i]);
            _word.Add(word);
        }
        _reference = new Reference(chapter, book, start, end);
    }




    public void GetRenderedText()
    {
        _reference.DisplayReference();

        for (int i = 0; i < _word.Count; i++)
        {
            if (!_word[i].IsHidden())
            {
                Console.Write($"{_word[i].GetWord()} ");
            }

            else
            {
                Console.Write($"{new string('_', _word[i].GetWord().Length)} ");
            }
        }
        Console.WriteLine("");
    }
    public void Hide3Words()
    { 
        int indexesHidden = 0;

        do{
            Random random = new Random();
            int index = random.Next(0, _word.Count);
            if (!_word[index].IsHidden())
            {
                _word[index].SetHidden();
                indexesHidden ++;
            }
            
        } while (indexesHidden < 3);
        indexesHidden = 0;
    }

    public string IsCompletelyHidden()
    {
        for(int index = 0; index < _word.Count; index++)
        {
            if (!_word[index].IsHidden())
            {
                return  "Not fully hidden";
            }
                
        }
        return "quit"; 
    }


}