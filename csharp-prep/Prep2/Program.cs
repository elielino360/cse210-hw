using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in percentage?");
        string Grade = Console.ReadLine();
        int Number= int.Parse(Grade);
        
        
        //getting the last digit from user input
        int LastDigit = Number % 10;
        
        string sign ="";

        if (LastDigit >= 7)
        {
            sign ="+";

        }
        else if (LastDigit < 3)
        {
            sign="-";
        }


        Console.WriteLine($"The last digit of your grade is: {LastDigit}");



        string letter="";

        if (Number >=90)
        {
            letter="A";
            if (Number <=97)
            {
                sign="-";
            }
        }
        else if (Number >= 80)
        {
            letter="B";
        }
    
        else if (Number >=70)
        {
            letter="C";
        }
        else if (Number >=60)
        {
            letter ="D";
        }
        else
        {
            letter="F";
            if (Number <=50)
            {
                sign="";
            }
        }
    

        if (Number >=70)
        {

        Console.WriteLine($"Your Grade is {letter} {sign}"); 

            Console.Write("Congratulations you passed");
        }
    
        else if (Number <70)
        {
            Console.Write(" You failed this exam, Try again next year ");
        }


    }
}