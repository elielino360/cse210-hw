public class WritingAssignment:Assignment
{
    private string _title ="";

    public WritingAssignment(string studentName, string topic,  string title) :base(studentName, topic)
    {
        _title=title;
    }

    public string Gettitle()
    {
        return _title;
    }

    public void Settitle(string title)
    {
        _title=title;
    }

    public string GetWritinginformation()
    {
        return ($"Name: {GetstudentName()} title: {_title} ");
    }
}

