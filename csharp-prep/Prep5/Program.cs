using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
    DisplayWelcomeMsg();

    string UserName = PromptUsername();
    int userNumber = PromptUserNumber();
    int Square = SquareNumber(userNumber);

    DisplayResult(UserName, Square);
   
    
    }

    static void DisplayWelcomeMsg()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUsername()
    {
        Console.Write("Please enter your name:");
        string Name=Console.ReadLine();

        return Name;
    }
    static int PromptUserNumber()
    {
         Console.Write("Please enter your favorite number:");
         string Number=Console.ReadLine();
         int MyNumber= int.Parse(Number);

         return MyNumber;

    }

    static int SquareNumber(int MyNumber)
    {
        int MysquaredNumber = MyNumber * MyNumber;

        return MysquaredNumber;
    }

    static void DisplayResult(string Name, int MysquaredNumber)
    {
        Console.WriteLine($"{Name}, the square of your number is {MysquaredNumber}");
    }
}
