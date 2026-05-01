using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ask the user for their age
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            // Convert the input to an integer
            int age = Convert.ToInt32(input);

            // Check if age is zero or negative
            if (age <= 0)
            {
                // Throw a custom exception for invalid age
                throw new ArgumentException("Age must be greater than zero.");
            }

            // Get the current year
            int currentYear = DateTime.Now.Year;

            // Calculate the birth year
            int birthYear = currentYear - age;

            // Display the result
            Console.WriteLine("You were born in: " + birthYear);
        }
        catch (ArgumentException ex)
        {
            // Handles zero or negative numbers
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            // Handles invalid input (like letters instead of numbers)
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (Exception)
        {
            // Handles any other unexpected errors
            Console.WriteLine("An unexpected error occurred. Please try again.");
        }

        // Keep console open
        Console.ReadLine();
    }
}
