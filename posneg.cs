using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstproject
{
    class posneg
    {
        public static void Main()
        {
            Console.WriteLine("enter any number:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("number is negative !!");
            }
            else
            {
                Console.WriteLine("number is positive !!");
            }

        }
        }
}
