using System;

namespace ToggleCase
{
    class t9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            string toggleCase = "";

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                {
                    toggleCase += char.ToLower(ch);  // Convert uppercase to lowercase
                }
                else if (char.IsLower(ch))
                {
                    toggleCase += char.ToUpper(ch);  // Convert lowercase to uppercase
                }
                else
                {
                    toggleCase += ch;  // Keep spaces and other characters unchanged
                }
            }

            Console.WriteLine("Toggle Case: " + toggleCase);
            Console.ReadLine();
        }
    }
}
