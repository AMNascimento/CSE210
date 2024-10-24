public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");

        foreach (string w in words)
        {
            Word word = new Word(w);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        
        for (int i = 0; i < numberToHide; i++)
        {
            List<int> visibleWords = ListVisibleWords();
            Random random = new Random();
            int index = random.Next(visibleWords.Count);
            if (visibleWords.Count > 0)
            {
                _words[visibleWords[index]].Hide();                
            }
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            if (text == "")
            {
                text += word.GetDisplayText();
            } else
            {
                text += $" {word.GetDisplayText()}";
            }
        }
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletlyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    private List<int> ListVisibleWords()
    {
        List<int> visibleWords = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleWords.Add(i);
            }
        }

        return visibleWords;
    }


}