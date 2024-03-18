class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = CreateWordList(text);
        _random = new Random();
    }

    private List<Word> CreateWordList(string text)
    {
        string[] wordTexts = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        return wordTexts.Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        int numWordsToHide = Math.Min(numberToHide, _words.Count(w => !w.IsHidden));

        // Select random words to hide
        List<Word> wordsToHide = _words.Where(w => !w.IsHidden).OrderBy(w => _random.Next()).Take(numWordsToHide).ToList();

        // Hide selected words
        foreach (Word word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n\n{_words.Aggregate("", (current, word) => current + (word.GetDisplayText() + " "))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}
