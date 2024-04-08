class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Introduction to C#", "ProgrammingWithElijah", 600),
            new Video("Advanced C# Tutorial", "ProgrammingWithElijah", 1200),
            new Video("C# Object Oriented Programming Tutorial", "ProgrammingWithElijah", 900)
        };

        videos[0].AddComment(new Comment("Elijah Ebinum", "Nice video!"));
        videos[0].AddComment(new Comment("Ebinum Jeremiah", "Very informative."));
        
        videos[1].AddComment(new Comment("Samuel Jackson", "This helped a lot, thanks!"));
        videos[1].AddComment(new Comment("Alicia Keys", "Looking forward to more!"));
        
        videos[2].AddComment(new Comment("Bruce Wayne", "Python is powerful."));
        videos[2].AddComment(new Comment("Chris William", "Thanks for the clear explanation."));

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._Name}: {comment._Text}");
            }
            Console.WriteLine(); 
        }
    }
}