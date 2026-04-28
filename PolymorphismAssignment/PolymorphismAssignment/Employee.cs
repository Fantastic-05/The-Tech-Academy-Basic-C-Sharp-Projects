using System;

// Employee class implements the IQuittable interface
public class Employee : IQuittable
{
    // Properties for the Employee
    public string Name { get; set; }
    public int Id { get; set; }

    // Implement the Quit() method from the interface
    public void Quit()
    {
        // This is what happens when Quit() is called
        Console.WriteLine(Name + " has quit the job.");
    }
}
