//I HAD SOME EXTRA IN THE PROGRAM, SOMETIMES THE USER TRY TO FIND THE CORRECT WORD BUT HE IS STRUGGLING SO
//HE CAN ASK FOR HELP AND WE WILL SHOW HIM THE ANSWER INSTEAD OF RESTARTING THE PROGRAM. 
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
            Console.WriteLine("Press enter to continue or type 'quit' to finish (If you have some struggle, enter 'help'):");
            response = Console.ReadLine();
            if(response == "quit")
            {
                break;
            }else if(response == "help")
            {
                Console.WriteLine(script1.GetText());
                break;
            }
        }

    }
}