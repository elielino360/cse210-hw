class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 03), 30, 3),
            new Cycling(new DateTime(2022, 11, 03), 45, 15),
            new Swimming(new DateTime(2022, 11, 03), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}