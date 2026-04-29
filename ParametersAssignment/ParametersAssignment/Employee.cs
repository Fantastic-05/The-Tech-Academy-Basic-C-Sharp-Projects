using System;
using System.Collections.Generic;

// Generic Employee class (T can be any data type)
public class Employee<T>
{
    // Property called "Things" which is a list of type T
    public List<T> Things { get; set; }
}
