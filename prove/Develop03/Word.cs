using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class Word
{
    private string _word;

    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void SetHidden()
    {
        _isHidden = true;
    }

    public string GetWord()
    {
        string word = _word;
        return word;
    } 
    public bool IsHidden()
    {
        return _isHidden;
    }
}