using System;

class SampleApplication
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}

csc/target:exe SampleApplication.cs

SampleApplication.exe

csc/target: library SampleApplication.cs

