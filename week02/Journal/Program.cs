using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);

                    Console.Write("> ");
                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToShortTimeString();

                    Entry newEntry = new Entry(date, time, prompt, response);
                    theJournal.AddEntry(newEntry);
                    break;

                case "2":
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    break;

                case "5":
                    Console.Write("Enter keyword: ");
                    string keyword = Console.ReadLine();
                    theJournal.SearchEntries(keyword);
                    break;

                case "6":
                    running = false;
                    break;
            }
        }
    }
}