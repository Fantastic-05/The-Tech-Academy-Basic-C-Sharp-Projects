using System;

namespace PackageExpressApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the package is too heavy
            if (weight > 50)
            {
                // Display error message and end program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return; // Stops the program
            }

            // Ask the user to enter the package width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // Ask the user to enter the package height
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // Ask the user to enter the package length
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Calculate the total dimensions
            double totalDimensions = width + height + length;

            // Check if the package is too large
            if (totalDimensions > 50)
            {
                // Display error message and end program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return; // Stops the program
            }

            // Calculate the shipping quote:
            // (width * height * length * weight) / 100
            double quote = (width * height * length * weight) / 100;

            // Display the result formatted as currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

            // Thank the user
            Console.WriteLine("Thank you!");

            // Keep console open
            Console.ReadLine();
        }
    }
}
