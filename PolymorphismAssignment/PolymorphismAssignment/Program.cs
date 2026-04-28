using System;

class Program
{
    static void Main()
    {
        // Create an object of Employee but assign it to an interface type (polymorphism)
        IQuittable employee = new Employee
        {
            Name = "John",
            Id = 1
        };

        // Call the Quit() method using the interface reference
        employee.Quit();

        // Keep console open
        Console.ReadLine();
    }
}