using System;
// Journal design notes:
// What does the program do?
// 1. Create a journal entry
// 2. Display journal entries by iteration
// 3. Save journal entries to a file
// 4. Load journal entries from a file
// 5. Provide a menu that allows users to choose
//   different actions
// 6. List prompts, at least 5. Add into a list.
// 7. Exit the program
//
// Design Requirements:
// Classes needed: at least 2
// Class 1: Journal
// Class 2: Entry
// Demonstrate abstraction
// Do not stress about: .csv file handling with commas and quotes
// just use a symbol for a separator like | or ~
// 
// Creativity: 
// EXCEEDING CORE REQUIREMENTS:
// 1. JSON save/load (options 6 & 7) - modern, clean format that's easier to parse and use in other apps
// 2. List-based architecture - dynamic storage with efficient add/remove operations
// 3. Auto-append .json extension - user-friendly filename handling
// 4. Full path display - shows exactly where files are saved for easy access
// 
// JOURNAL CLASS
// ------------------------
// Attributes (member variables):
//   _entries: List<Entry>          - stores all journal entries
//   _prompts: List<string>          - stores list of writing prompts
// 
// Methods:
//   Constructor Journal()           - initialize empty lists
//   AddEntry(Entry entry): void     - adds a new entry to the list
//   Display(): void                 - loops through and displays all entries
//   GetRandomPrompt(): string       - picks a random prompt from the list
//   SaveToFile(string filename): void   - writes all entries to a file
//   LoadFromFile(string filename): void - reads entries from a file into the list

// Entry CLASS
// ------------------------
// Attributes (member variables):
//   _date: string                   - date entry was created
//   _prompt: string                 - the writing prompt used
//   _response: string               - user's response to the prompt
// 
// Methods:
//   Constructor Entry(date, prompt, response) - sets all three values
//   Display(): void                 - prints the entry in a nice format
// 

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        while (true)
        {
            int choice = DisplayMenu();
            if (choice == 1)
            {
                // Write a new journal entry
                string prompt = myJournal.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();
                Entry newEntry = new Entry(date, prompt, response);
                myJournal.AddEntry(newEntry);

                Console.WriteLine("\nEntry added successfully!\n");
            }
            else if (choice == 2)
            {
                // Display all journal entries
                Console.WriteLine("\n--- Journal Entries ---");
                myJournal.Display();
            }
            else if (choice == 3)
            {
                // Load journal entries from a file
                Console.Write("\nEnter filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded!\n");
            }
            else if (choice == 4)
            {
                // Save journal entries to a file
                Console.Write("\nEnter filename to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
                Console.WriteLine("Journal saved!\n");
            }
            else if (choice == 5)
            {
                // Quit the program
                break;
            }
            else if (choice == 6)
            {
                // Save to JSON
                Console.Write("\nEnter filename to save (JSON): ");
                string filename = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(filename) &&
                    !filename.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    filename += ".json";
                }
                myJournal.SaveToJson(filename);
            }
            else if (choice == 7)
            {
                // Load from JSON
                Console.Write("\nEnter filename to load (JSON): ");
                string filename = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(filename) &&
                    !filename.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    filename += ".json";
                }
                myJournal.LoadFromJson(filename);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

    }
    static int DisplayMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load (text file)");
        Console.WriteLine("4. Save (text file)");
        Console.WriteLine("5. Quit");
        Console.WriteLine("6. Save (JSON)");
        Console.WriteLine("7. Load (JSON)");
        Console.WriteLine("--------------------------------");
        Console.WriteLine();

        // Show menu, get user input, call Journal methods
        Console.Write("Please select an option: ");
        string input = Console.ReadLine();
        int userInput = 0;

        if (!int.TryParse(input, out userInput))
        {
            // handling invalid input (non-integer)
            userInput = -1;
        }

        return userInput;  // Give back the user's choice
    }
}