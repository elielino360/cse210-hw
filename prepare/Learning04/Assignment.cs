public class Assignment
{
    private string _studentName="";
    private string _topic="";

   public Assignment(string studentName, string topic)
   {
    _studentName = studentName;
    _topic = topic;
   }

   public string GetstudentName()
   {
    return _studentName;
   }


   public string Gettopic()
   {
    return _topic;
   }


   public string GetSummary()
   {
    return ($" Student name: {_studentName} Topic: {_topic}");
   }

}
