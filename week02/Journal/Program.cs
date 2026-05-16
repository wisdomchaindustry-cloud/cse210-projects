using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeded requirements by adding:
        // 1. Entry count feature
        // 2. Timestamp for journal entries
        // 3. Search functionality for journal entries

        Journal theJournal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 6)
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

            choice = int.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);

                Console.Write("> ");

                string response = Console.ReadLine()!;

                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToShortDateString();

                newEntry._time = DateTime.Now.ToShortTimeString();

                newEntry._promptText = prompt;

                newEntry._entryText = response;

                theJournal.AddEntry(newEntry);
            }

            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename: ");

                string file = Console.ReadLine()!;

                theJournal.SaveToFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename: ");

                string file = Console.ReadLine()!;

                theJournal.LoadFromFile(file);
            }

            else if (choice == 5)
            {
                Console.Write("Enter keyword to search: ");

                string keyword = Console.ReadLine()!;

                theJournal.SearchEntries(keyword);
            }
        }
    }
}