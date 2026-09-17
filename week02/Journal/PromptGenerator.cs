using System;
using System.Collections.Generic;

public class PromptGenerator
{
    List<string> _prompts;

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "Who made me smile or laugh today, and why?",
            "What is one kind thing someone did for me today?",
            "Who did I help or lift up today?",
            "How did I see the hand of the Lord in my life today?",
            "What is one small thing I am deeply grateful for tonight?",
            "When did I feel a sense of true peace today?",
            "What beautiful sight in nature caught my attention today?",
            "How did I practice love, patience, or kindness today?",
            "What was the strongest emotion I felt today?",
            "What triggered that strong emotion, and how did I handle it?",
            "Is there anything weighing heavily on my mind that I need to let go of tonight?",
            "What drained my energy the most today?",
            "What energized me or made me excited today?",
            "If I had one thing I could do over today, what would it be?",
            "What is the most important lesson I learned today?",
            "How did I handle a mistake or a challenge today?",
            "What did I discover about myself today that I didn't know before?",
            "What was a \"small win\" I achieved today?"
        };

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0,_prompts.Count);
        Console.WriteLine(_prompts[number]);
        Console.Write(">");
        return _prompts[number];
    }
}