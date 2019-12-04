using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class pattern7
    {
        public static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
