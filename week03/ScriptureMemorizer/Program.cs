using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Alma",37,35);
        Scripture script1 = new Scripture(ref1,"Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.");
    
        

        string response;
        int hiddenWord = 0;

        while (!script1.IsCompletelyHidden())
        {
            
            Console.Clear();
            script1.HideRandomWords(hiddenWord++);
            Console.WriteLine(script1.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            if(response == "quit")
            {
                break;
            }
        }

    }
}