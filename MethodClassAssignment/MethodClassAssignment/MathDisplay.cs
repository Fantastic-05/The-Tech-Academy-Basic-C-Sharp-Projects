using System;

// This class contains a void method that performs a math operation
public class MathDisplay
{
    // This method takes two integers as parameters
    // It performs a math operation on the first number
    // and displays the second number to the console
    public void DoMath(int num1, int num2)
    {
        // Perform a math operation on the first number (example: multiply by 2)
        int result = num1 * 2;

        // Display the result of the math operation
        Console.WriteLine("Result of first number * 2: " + result);

        // Display the second number
        Console.WriteLine("Second number is: " + num2);
    }
}