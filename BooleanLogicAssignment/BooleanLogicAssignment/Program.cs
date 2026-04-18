using System;

namespace CarInsuranceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their age
            Console.WriteLine("What is your age?");

            // Read input from the user and convert it to an integer
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask the user if they have had a DUI
            Console.WriteLine("Have you ever had a DUI? (true/false)");

            // Read input and convert it to a boolean value
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // Ask the user how many speeding tickets they have
            Console.WriteLine("How many speeding tickets do you have?");

            // Read input and convert it to an integer
            int tickets = Convert.ToInt32(Console.ReadLine());

            // Apply the business rules:
            // 1. Must be older than 15
            // 2. Must NOT have a DUI
            // 3. Must have 3 or fewer speeding tickets
            bool isQualified = (age > 15) && (hasDUI == false) && (tickets <= 3);

            // Display the result
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}