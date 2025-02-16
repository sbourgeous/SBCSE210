public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public Reference(string referenceText)
    {
        var parts = referenceText.Split(' ');
        _book = parts[0];
        var chapterVerse = parts[1].Split(':');
        _chapter = int.Parse(chapterVerse[0]);
        
        var verses = chapterVerse[1].Split('-');
        _startVerse = int.Parse(verses[0]);
        _endVerse = verses.Length > 1 ? int.Parse(verses[1]) : _startVerse;
    }

    public string GetDisplayContent()
    {
        return _startVerse == _endVerse 
            ? $"{_book} {_chapter}:{_startVerse}" 
            : $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}