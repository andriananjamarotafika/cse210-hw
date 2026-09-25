using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference ;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string [] cleanWords = text.Split(" ");
        foreach (string word in cleanWords)
        { 
            _words.Add(new Word(word));
        }
        
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0 ; i < numberToHide ; i++)
        {
            int randomIndex = random.Next(_words.Count);
            Word wordsToHide = _words[randomIndex];
            if (!wordsToHide.isHidden())
            { 
                wordsToHide.Hide();
            }
            else
            {
                if (_words.All(word => word.isHidden()))
                {
                    break;
                }

                i--;
            }

        }

    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplay()} {string.Join(" ",_words)}" ;
    }

    public bool IsCompletelyHidden()
    {
        var decision = true;
        foreach(Word word in _words)
        {
            if (word.isHidden())
            {
                decision = true;
            }
            else
            {
                decision = false;
                break;
            }
        }
        return decision;
    }

}