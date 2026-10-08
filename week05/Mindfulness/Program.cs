using System;
//I KEEP LOG OF HOW MANY TIMES ACTIVITIES WERE PERFORMED IN THE FOURTH OPTIONS AND I ADD AN FIFTH OPTION TO QUIT THE PROGRAM
class Program
{
    static void Main(string[] args)
    {
        int options = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("""
        Menu Options :
            1. Start breathing activity
            2. Start reflecting activity
            3. Start listing activity
            4. List iteration of the activities
            5. Quit
        """);
            Console.Write("Select a choice frome the menu : ");
            options = int.Parse(Console.ReadLine());
            if (options == 1)
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.Run();
            }
            else if (options == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflecting.Run();
            }
            else if (options == 3)
            {
                ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.Run();
            }
            else if (options == 4)
            {
                Console.Clear();
                Console.WriteLine($"The Breathing Activity has {BreathingActivity.GetBreatheIteration()} iteration(s).");
                Console.WriteLine($"The Breathing Activity has {ReflectingActivity.GetReflectIteration()} iteration(s).");
                Console.WriteLine($"The Breathing Activity has {ListingActivity.GetListIteration()} iteration(s).");
                Thread.Sleep(5000);
            }
            else if (options == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Error number,Re do it");
                Thread.Sleep(3000);
            }

        } while (options != 5);

    }
}