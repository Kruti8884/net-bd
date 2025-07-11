using System;  // Importing the System namespace to use basic classes like Console

namespace ConsoleApplication1  // Defining a namespace for the application
{
    class t5  // Declaring a class named Program
    {
        static void Main(string[] args)  // Entry point of the program
        {
            int n, fact = 1;  // Declare an integer 'n' and initialize 'fact' to 1

            Console.WriteLine("Enter Number : ");  // Prompt the user to enter a number

            string str = Console.ReadLine();  // Read the input from the user as a string

            n = Convert.ToInt32(str);  // Convert the input string to an integer and store in 'n'

            for (int i = 1; i <= n; i++)  // Loop from 1 to 'n'
            {
                fact = fact * i;  // Multiply 'fact' by 'i' in each iteration to compute factorial
            }

            Console.WriteLine("Factorial : {0}", fact);  // Display the calculated factorial

            Console.Read();  // Wait for a key press to keep the console window open
        }
    }
}
