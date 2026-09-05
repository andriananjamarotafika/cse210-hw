using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade? ");
        int grade = int.Parse(Console.ReadLine());
        string sign;
        int lastDigit = grade % 10;
        
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (grade >= 97)
        {
            Console.WriteLine("You got an A!");
        }
        else if (grade >= 90)
        {
            Console.WriteLine($"You got an A{sign}!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"You got a B{sign}!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine($"You got a C{sign}!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine($"You got a D{sign}!");
        }
        else
        {
            Console.WriteLine("You got an F!");
        }
    }
}