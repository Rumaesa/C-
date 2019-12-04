using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstproject
{
    class Subject
    {
        public static void Main()
        {
            Console.WriteLine("enter marks of 1st subject:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks of 2nd subject:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks of 3rd subject:");
            int s3 = Convert.ToInt32(Console.ReadLine());

            int total = s1 + s2 + s3;
            int percent = total / 3 ;
            //int percent = per * 3;
            Console.WriteLine("Total of all subject is:" + total);
            Console.WriteLine("Percentage is:" + percent);
            if (percent < 35)
            {
                Console.WriteLine("you are FAIL!!");
            }
            else if (percent >= 35 && percent < 60)
            {
                Console.WriteLine("2nd class");
            }
            else if (percent >= 60 && percent < 75)
            {
                Console.WriteLine("1st class");
            }
            else 
            {
                Console.WriteLine("***DISTINCTION***");
            }
            



         

        }

    }
}
