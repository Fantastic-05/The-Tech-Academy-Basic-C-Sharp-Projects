using System;

using System.Text; // Needed for StringBuilder

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------- Concatenate three strings --------

            // Declare three separate string variables
            string firstString = "Hello";
            string secondString = "there";
            string thirdString = "friend!";

            // Combine (concatenate) the three strings into one
            string combinedString = firstString + " " + secondString + " " + thirdString;

            // Display the concatenated result
            Console.WriteLine("Concatenated string:");
            Console.WriteLine(combinedString);


            // -------- Convert a string to uppercase --------

            // Declare a string
            string message = "this is a lowercase sentence.";

            // Convert the string to uppercase using ToUpper()
            string upperMessage = message.ToUpper();

            // Display the uppercase result
            Console.WriteLine("\nUppercase string:");
            Console.WriteLine(upperMessage);


            // -------- Use StringBuilder to build a paragraph --------

            // Create a new StringBuilder object
            StringBuilder paragraph = new StringBuilder();

            // Append sentences one at a time
            paragraph.Append("This is the first sentence. ");
            paragraph.Append("Here is the second sentence. ");
            paragraph.Append("Finally, this is the third sentence.");

            // Display the full paragraph
            Console.WriteLine("\nParagraph built with StringBuilder:");
            Console.WriteLine(paragraph);


            // Keep console open until user presses Enter
            Console.ReadLine();
        }
    }
}