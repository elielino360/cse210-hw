using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {

        List<int> Number = new List<int>();
        int ConNumber;
        do
        {
            Console.Write("Enter number:");
            string MyNumber =Console.ReadLine();
            ConNumber= int.Parse(MyNumber);

            if (ConNumber!=0)
            {
                Number.Add(ConNumber);
            }


        } while(ConNumber !=0);
        
        int MyCount= Number.Count();

        int max=Number[0];

        int totalNumber=0;
        foreach (int numbers in Number)
        {
            totalNumber +=numbers;
            if (numbers > max)
            {
                max=numbers;
            }
            

        }
        Console.WriteLine($"The sum is {totalNumber}");

        int AverageNumber=totalNumber/MyCount;

        Console.WriteLine($"The Average Number is {AverageNumber}");

        Console.WriteLine($"The max Number is {max}");

        Number.Sort();
        
        Console.WriteLine("The sorted list is:");

        foreach (int Num in Number)
        {
            
             Console.WriteLine(Num);

        }



    }
}