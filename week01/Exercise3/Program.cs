using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Random randomGenerator = new Random();
            // Console.WriteLine("What is the magic number?");
            int magicNumber = randomGenerator.Next(1, 101);
            bool isGuessed = false;
            int guessCount = 0;
            while (!isGuessed)
            {
                Console.WriteLine("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());
                guessCount++;
                if (guess < magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                    isGuessed = true;
                }
            }
            Console.WriteLine("Do you want to play again? (yes/no)");
            response = Console.ReadLine();
        }while(response == "yes");
       
    }
}