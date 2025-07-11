using System;

namespace MaskMobileNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter mobile number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string masked = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
                Console.WriteLine("Masked Mobile Number: " + masked);
            }
            else
            {
                Console.WriteLine("Invalid input. Mobile number must be at least 5 digits.");
            }

            Console.ReadLine();
        }
    }
}
