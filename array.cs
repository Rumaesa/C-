using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstproject
{
    class array
    {
        public static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("please enter any 5 number:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Entered numbers are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int max = arr[0];
            for (int i = 1; i <= 5; i++)
            {
                if (max >= arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum no is:"+max);

        }

    }
}
