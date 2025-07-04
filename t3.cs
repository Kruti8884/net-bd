using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class t3
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is Even.");
                }
                else
                {
                    Console.WriteLine($"{number} is Odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
