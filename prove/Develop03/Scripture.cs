public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _scripture = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetDisplayContent()
    {
        return $"{_reference.GetDisplayContent()} " + string.Join(" ", _scripture.Select(w => w.GetDisplayContent()));
    }

    public void HideAWord(int num)
    {
        var random = new Random();
        var wordsToHide = _scripture.Where(w => !w.IsHidden()).OrderBy(_ => random.Next()).Take(num);
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool IsAllHidden()
    {
        return _scripture.All(w => w.IsHidden());
    }
}