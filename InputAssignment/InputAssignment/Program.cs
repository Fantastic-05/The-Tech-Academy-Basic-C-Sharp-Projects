using System;
using System.IO; // Required for file operations

class Program
{
    static void Main()
    {
        // Ask the user to enter a number
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine(); // Read input as string

        // Define the file path (file will be created in the project folder)
        string filePath = "numberLog.txt";

        // Write the user's input to the text file
        // If the file does not exist, it will be created
        File.WriteAllText(filePath, userInput);

        // Read the content of the text file
        string fileContent = File.ReadAllText(filePath);

        // Display the content back to the user
        Console.WriteLine("\nContent of the file:");
        Console.WriteLine(fileContent);

        // Keep console open until user presses Enter
        Console.ReadLine();
    }
}
