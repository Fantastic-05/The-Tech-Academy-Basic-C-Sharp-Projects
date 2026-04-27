using System;

class Program
{
    static void Main()
    {
        // Instantiate (create an object of) the MathDisplay class
        MathDisplay math = new MathDisplay();

        // Call the method by passing arguments normally
        math.DoMath(5, 10);

        Console.WriteLine(); // blank line for readability

        // Call the method using named parameters
        math.DoMath(num1: 7, num2: 20);

        // Keeps console window open until user presses a key
        Console.ReadLine();
    }
}