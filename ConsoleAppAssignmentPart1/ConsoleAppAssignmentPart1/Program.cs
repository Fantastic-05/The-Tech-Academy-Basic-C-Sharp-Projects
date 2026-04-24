using System;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings
        string[] words = { "Apple", "Banana", "Cherry", "Date" };

        // Ask the user to input some text
        Console.Write("Enter some text to add: ");
        string userInput = Console.ReadLine();

        // First loop: append user input to each string (no output here)
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + userInput;
        }

        // Second loop: print each updated string
        Console.WriteLine("\nUpdated array:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
