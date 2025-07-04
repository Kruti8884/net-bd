using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1:");
            //type casting
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number 2:");
            int b=int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of two numbers is:"+ (a + b));
        }
    }
}
