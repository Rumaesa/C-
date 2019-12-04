using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstproject
{
    class Addition
    {
        public static void Main()
        {
            Addition obj = new Addition();
            int x = obj.add();
            Console.WriteLine("addition is:" +x);

        }

        public int add()
        {
            int c;
            
            Console.WriteLine("enter 1st value :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 2nd value :");
            int b = Convert.ToInt32(Console.ReadLine());

            c = a + b;

            Console.WriteLine("the addition of " +a +" and " +b +" is: " +c);
            return c;
        }

    }
}
