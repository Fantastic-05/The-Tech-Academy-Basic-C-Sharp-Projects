using System;

namespace IncomeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the title of the program
            Console.WriteLine("Anonymous Income Comparison Program");

            // -------- Person 1 --------
            Console.WriteLine("\nPerson 1");

            // Ask for hourly rate for Person 1
            Console.WriteLine("Enter hourly rate:");
            double p1HourlyRate = Convert.ToDouble(Console.ReadLine());

            // Ask for hours worked per week for Person 1
            Console.WriteLine("Enter hours worked per week:");
            double p1HoursPerWeek = Convert.ToDouble(Console.ReadLine());

            // Calculate annual salary (hourly rate * hours per week * 52 weeks)
            double p1AnnualSalary = p1HourlyRate * p1HoursPerWeek * 52;

            // -------- Person 2 --------
            Console.WriteLine("\nPerson 2");

            // Ask for hourly rate for Person 2
            Console.WriteLine("Enter hourly rate:");
            double p2HourlyRate = Convert.ToDouble(Console.ReadLine());

            // Ask for hours worked per week for Person 2
            Console.WriteLine("Enter hours worked per week:");
            double p2HoursPerWeek = Convert.ToDouble(Console.ReadLine());

            // Calculate annual salary for Person 2
            double p2AnnualSalary = p2HourlyRate * p2HoursPerWeek * 52;

            // -------- Output Results --------

            // Display Person 1's annual salary
            Console.WriteLine("\nAnnual salary of Person 1:");
            Console.WriteLine(p1AnnualSalary);

            // Display Person 2's annual salary
            Console.WriteLine("\nAnnual salary of Person 2:");
            Console.WriteLine(p2AnnualSalary);

            // Compare salaries and check if Person 1 earns more
            bool doesP1MakeMore = p1AnnualSalary > p2AnnualSalary;

            // Display comparison result
            Console.WriteLine("\nPerson 1 makes more money than Person 2:");
            Console.WriteLine(doesP1MakeMore);

            // Keep console window open until user presses Enter
            Console.ReadLine();
        }
    }
}