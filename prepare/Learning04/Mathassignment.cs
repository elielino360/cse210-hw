public class Mathassignment : Assignment
{

    private string _textBook="";
    private string _problems="";

    public Mathassignment( string studentName, string topic, string textbook, string problems) 
    : base (studentName, topic)
    {
        _textBook =textbook;
        _problems = problems;
    }

    public string Gettextbook()
    {
        return _textBook;
    }

    public void Settextbok(string textbook)
    {

        _textBook = textbook;

    }

    public string Getproblems()
    {
        return _problems;
    }

    public void Setproblems(string problems)
    {
        _problems=problems;
    }


    public string GetHomeworkList()
    {
        return ($"Textbook:{_textBook} problems:{_problems}");
    }


}

