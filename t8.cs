using System;

namespace ConvertToUpper
{
    class t8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");               // Prompt user for input
            string name = Console.ReadLine();                 // Read the input string
            string upperName = name.ToUpper();                // Convert to uppercase
            Console.WriteLine("Uppercase Name: " + upperName); // Display result
            Console.ReadLine();                               // Wait for user input before closing
        }
    }
}
