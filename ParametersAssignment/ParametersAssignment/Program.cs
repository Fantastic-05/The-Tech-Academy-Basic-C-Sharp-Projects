using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // -----------------------------------------
        // Employee with string type
        // -----------------------------------------

        // Create an Employee object that holds strings
        Employee<string> stringEmployee = new Employee<string>();

        // Assign a list of strings to Things property
        stringEmployee.Things = new List<string>
        {
            "Laptop",
            "Phone",
            "Notebook"
        };

        // -----------------------------------------
        // Employee with int type
        // -----------------------------------------

        // Create an Employee object that holds integers
        Employee<int> intEmployee = new Employee<int>();

        // Assign a list of integers to Things property
        intEmployee.Things = new List<int>
        {
            10,
            20,
            30
        };

        // -----------------------------------------
        // Print all items (strings)
        // -----------------------------------------

        Console.WriteLine("String Employee Things:");
        foreach (string item in stringEmployee.Things)
        {
            Console.WriteLine(item);
        }

        // -----------------------------------------
        // Print all items (integers)
        // -----------------------------------------

        Console.WriteLine("\nInteger Employee Things:");
        foreach (int item in intEmployee.Things)
        {
            Console.WriteLine(item);
        }

        // Keep console open
        Console.ReadLine();
    }
}
