using System;

// Define a struct called Number
// A struct is a value type used to store small data objects
public struct Number
{
    // Property called Amount of type decimal
    public decimal Amount { get; set; }
}

class Program
{
    static void Main()
    {
        // Create an object of type Number
        Number myNumber = new Number();

        // Assign a value to the Amount property
        myNumber.Amount = 123.45m; // 'm' indicates a decimal value

        // Print the value to the console
        Console.WriteLine("The amount is: " + myNumber.Amount);

        // Keep console window open until user presses Enter
        Console.ReadLine();
    }
}
