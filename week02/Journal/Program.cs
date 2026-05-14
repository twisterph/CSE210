using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Journal Program");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string prompt = promptGenerator.GetRandomPrompt();

        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();
        entry._promptText = prompt;
        entry._entryText = "Today I learned about abstraction.";

        journal.AddEntry(entry);

        journal.DisplayAll();
    }
}