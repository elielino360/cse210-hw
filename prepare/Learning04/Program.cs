using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Assignment1= new Assignment("Elijah", "Computer Science");
        Console.WriteLine(Assignment1.GetSummary());

        Mathassignment Mathassignment1 = new Mathassignment("Ebinum", "Python", "Loops", "While statement");
        Console.WriteLine(Mathassignment1.GetSummary());
        Console.WriteLine(Mathassignment1.GetHomeworkList());

        WritingAssignment WritingAssignment1= new WritingAssignment("Yerimi", "Calculus", "intro to programming" );
        Console.WriteLine(WritingAssignment1.GetSummary());
        Console.WriteLine(WritingAssignment1.GetWritinginformation());

    }
}