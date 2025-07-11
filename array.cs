using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_bd
{
    internal class array
    {
        static void Main(string[] args)
        {
            int[] a= new int[5] { 1, 2, 3, 4, 5 };
            //inex wise iteration
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }

            //foreach loop element wise

            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
