using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.WriteLine("Enter a number:");

            // Read user input and convert it to a double (handles large numbers and decimals)
            double userNumber = Convert.ToDouble(Console.ReadLine());

            // Multiply the number by 50 and display the result
            double multiplyResult = userNumber * 50;
            Console.WriteLine("Number multiplied by 50: " + multiplyResult);

            // Ask the user for another number
            Console.WriteLine("\nEnter another number:");

            // Read input and convert to double
            double addNumber = Convert.ToDouble(Console.ReadLine());

            // Add 25 to the number and display the result
            double addResult = addNumber + 25;
            Console.WriteLine("Number plus 25: " + addResult);

            // Ask the user for another number
            Console.WriteLine("\nEnter another number:");

            // Read input and convert to double
            double divideNumber = Convert.ToDouble(Console.ReadLine());

            // Divide the number by 12.5 and display the result
            double divideResult = divideNumber / 12.5;
            Console.WriteLine("Number divided by 12.5: " + divideResult);

            // Ask the user for another number
            Console.WriteLine("\nEnter another number:");

            // Read input and convert to double
            double checkNumber = Convert.ToDouble(Console.ReadLine());

            // Check if the number is greater than 50 and display true/false
            bool isGreaterThanFifty = checkNumber > 50;
            Console.WriteLine("Is the number greater than 50? " + isGreaterThanFifty);

            // Ask the user for another number
            Console.WriteLine("\nEnter another number:");

            // Read input and convert to int (needed for modulus operation)
            int remainderNumber = Convert.ToInt32(Console.ReadLine());

            // Divide the number by 7 and get the remainder
            int remainderResult = remainderNumber % 7;
            Console.WriteLine("Remainder when divided by 7: " + remainderResult);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}