using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Alma",37,35);
        Scripture script1 = new Scripture(ref1,"1 2 3 4 5 6 7 8 9 10 11 12");

        // Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.
        string response;
        int hiddenWord = 0;
        do
        {
            Console.Clear();
            Console.WriteLine(script1.GetDisplayText());
            response = Console.ReadLine();
            if(response == "quit")
            {
                break;
            }
            script1.HideRandomWords(1);
        }while (!script1.IsCompletelyHidden());

    }
}