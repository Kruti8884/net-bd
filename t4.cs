using System;

namespace ConsoleApplication1
{
    class t4
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            string str = Console.ReadLine();

            int x;
            if (int.TryParse(str, out x))
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("Number is Even");
                }
                else
                {
                    Console.WriteLine("Number is Odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.ReadLine(); // Pause the console
        }
    }
}
