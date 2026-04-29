using System;

class Program
{
    static void Main()
    {
        // Create first Employee object
        Employee emp1 = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        // Create second Employee object
        Employee emp2 = new Employee
        {
            Id = 1,
            FirstName = "Jane",
            LastName = "Smith"
        };

        // Compare employees using overloaded == operator
        bool isEqual = (emp1 == emp2);

        // Display result
        Console.WriteLine("Are employees equal? " + isEqual);

        // Compare using != operator
        bool isNotEqual = (emp1 != emp2);

        // Display result
        Console.WriteLine("Are employees NOT equal? " + isNotEqual);

        // Keep console open
        Console.ReadLine();
    }
}
