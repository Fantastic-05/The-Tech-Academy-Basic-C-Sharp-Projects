using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ======================================================
        // PART 1 - STRING ARRAY + USER INPUT APPENDING
        // ======================================================

        string[] words = { "Apple", "Banana", "Cherry", "Date" };

        // Ask user for input
        Console.Write("Enter some text to add: ");
        string userInput = Console.ReadLine();

        // Loop through array and append user input to each element
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + userInput;
        }

        // Display updated array
        Console.WriteLine("\nUpdated array:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }


        // ======================================================
        // PART 2 - FIXED INFINITE LOOP
        // ======================================================

        Console.WriteLine("\nStarting loop...");

        int counter = 0;

        // Fixed loop (counter increases so loop eventually ends)
        while (counter < 5)
        {
            Console.WriteLine("Counter: " + counter);
            counter++; // prevents infinite loop
        }


        // ======================================================
        // PART 3 - < AND <= LOOPS
        // ======================================================

        Console.WriteLine("\nLoop using < operator:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("i = " + i);
        }

        Console.WriteLine("\nLoop using <= operator:");
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("i = " + i);
        }


        // ======================================================
        // PART 4 - SEARCH LIST + STOP AT FIRST MATCH
        // ======================================================

        List<string> fruits = new List<string>
        {
            "Mango", "Orange", "Grapes", "Peach", "Kiwi"
        };

        Console.Write("\nEnter a fruit to search: ");
        string searchInput = Console.ReadLine();

        bool found = false;

        // Loop through list to find match
        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Found at index: " + i);
                found = true;
                break; // stops after first match
            }
        }

        // If nothing found, notify user
        if (!found)
        {
            Console.WriteLine("Your input is not on the list.");
        }


        // ======================================================
        // PART 5 - FIND MULTIPLE MATCHES (NO BREAK)
        // ======================================================

        List<string> items = new List<string>
        {
            "Apple", "Banana", "Cherry", "Apple", "Grapes", "Banana"
        };

        Console.Write("\nEnter text to search (multiple matches allowed): ");
        string searchText = Console.ReadLine();

        bool foundMatch = false;

        // Loop through full list to find ALL matches
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Match found at index: " + i);
                foundMatch = true;
            }
        }

        if (!foundMatch)
        {
            Console.WriteLine("Your input is not on the list.");
        }


        // ======================================================
        // PART 6 - FOREACH DUPLICATE CHECK
        // ======================================================

        List<string> letters = new List<string>
        {
            "A", "B", "C", "D", "C"
        };

        // Track items we've already seen
        List<string> seen = new List<string>();

        Console.WriteLine("\nDuplicate Check:");

        // foreach loop to check duplicates
        foreach (string letter in letters)
        {
            // If we've seen it before, it's a duplicate
            if (seen.Contains(letter))
            {
                Console.WriteLine(letter + " - this item is a duplicate");
            }
            else
            {
                Console.WriteLine(letter + " - this item is unique");
                seen.Add(letter); // mark as seen
            }
        }
    }
}