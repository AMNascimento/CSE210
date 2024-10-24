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
            List<int> visibleWords = ListVisibleWordsPosition();
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

    private List<int> ListVisibleWordsPosition()
    {
        List<int> visibleWordsPosition = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleWordsPosition.Add(i);
            }
        }

        return visibleWordsPosition;
    }

    public void ShowWords(string whichWord)
    {
        int number;
        if (whichWord == "all")
        {
            for (int i = 0; i < _words.Count; i++)
            {
                _words[i].Show();
            }
        }else if(Int32.TryParse(whichWord, out number))
        {
            if (number > 0 & number < _words.Count)
            {
                _words[number-1].Show();
            }
        }
    }


}