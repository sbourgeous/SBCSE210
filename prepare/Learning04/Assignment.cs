public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string topic, string studentName)
    {
        _topic = topic;
        _studentName = studentName;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}