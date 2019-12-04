using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstproject
{
    class largestno
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Largest number is"+a);
            }
            if (b > c && b > a)
            {
                Console.WriteLine("Largest number is" + b);
            }
            else
            {
                Console.WriteLine("Largest number is" +c);    
            }


        }

    }
}
