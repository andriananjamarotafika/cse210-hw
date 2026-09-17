//AS A CREATIVITY, I CREATE JSON STORAGE TO SAVE EVERYTHING THAT THE USER DO IN A FILE CALLED JsonFile.json SO USER
//CAN USE THAT TO CHECK EVERYTHING HE DID EVEN IF IT IS SEPARATE A DIFFERENT FILES
using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator _question = new PromptGenerator();
        Journal _journal = new Journal();
        int number;
        do
        {
            Console.Write("""
            Welcome to the Journal Program!
            Please select one of the following choices:
            1. Write
            2. Display
            3. Load
            4. Save
            5. Quit
            What would you like to do? 
            """);
            number = int.Parse(Console.ReadLine());
            if(number == 1)
            {
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = _question.GetRandomPrompt();
                entry._entryText = Console.ReadLine();
                _journal.AddEntry(entry);
                //save data to json
                _journal.SaveToJson(entry);
            }else if(number == 2)
            {
                _journal.DisplayAll();
            }else if(number == 3)
            {
                string fileName;
                Console.WriteLine("Enter the file name that you want to load: ");
                fileName = Console.ReadLine();
                _journal.LoadFromFile(fileName);
            }else if(number == 4)
            {
                string fileName;
                Console.WriteLine("Save as  (name.txt) : ");
                fileName = Console.ReadLine();
                _journal.SaveToFile(fileName);

            }else if(number == 5)
            {
                Console.WriteLine("Thank You!");
            }
            else 
            {
                Console.WriteLine("Invalid number.");
            }
        }while(number != 5);
        
        }

    }
