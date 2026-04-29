using System;

// Employee class with properties
public class Employee
{
    // Properties for Employee
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the == operator
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both are null, return true
        if (ReferenceEquals(emp1, emp2))
            return true;

        // If one is null, return false
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare Id properties
        return emp1.Id == emp2.Id;
    }

    // Overload the != operator (must be paired with ==)
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Return the opposite of ==
        return !(emp1 == emp2);
    }

    // Override Equals method (recommended when overloading ==)
    public override bool Equals(object obj)
    {
        // Check if object is Employee
        if (obj is Employee emp)
        {
            return this.Id == emp.Id;
        }
        return false;
    }

    // Override GetHashCode (required when overriding Equals)
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
