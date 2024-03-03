using System;

class Program
{
    static void Main(string[] args)
    {
    
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 101);

        int count=0;

        int GuessNumber;

        do 
        {
            Console.Write("What is your guess number?(guess within 100)");
            String UserGuess = Console.ReadLine();
            GuessNumber = int.Parse(UserGuess);
           count++;

            if (GuessNumber == MagicNumber)
            {
                Console.WriteLine("You Guess the right number");
                Console.WriteLine($"it took you {count} times to guess the magic number");

                Console.WriteLine("do you want to play again Yes/No");
                string question = Console.ReadLine();
                if (question=="Yes")
                {

                }
                else
                {
                    Console.WriteLine("Thank you for playing our Game");
                }

            }

            else if (GuessNumber < MagicNumber)
            {
                Console.WriteLine("Your guess is lower then our magic number. Guess higher ");
            }
            
            else if(GuessNumber > MagicNumber)
            {
                Console.WriteLine("Your guess is higher than our magic number. Guess lower");
            }
            
                
        } while (GuessNumber != MagicNumber);
        
    

    }


}