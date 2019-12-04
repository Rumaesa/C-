using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class pattern5
    {
        public static void Main()
        {
           //5 4 3 2 1
           //5 4 3 2
           //5 4 3
           //5 4
           //5

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            //1
            //1 2
            //1 2 3
            //1 2 3 4
            //1 2 3 4 5

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

           //1
           //2 2
           //3 3 3
           //4 4 4 4
           //5 5 5 5 5
            
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
           
            //1
            //2 3
            //4 5 6
            //7 8 9 10
            //11 12 13 14 15
            
            int a = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                  
                    Console.Write(" "+a);
                    a++;
                }
                Console.WriteLine();
            }

            //1 2 3 4 5
            //1 2 3 4 
            //1 2 3
            //1 2
            //1

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }

            //for (int i = 5; i >= 1; i--)
            //{
              //  for (int j = 1; j <= i; j++)
                //{
                   
                  //  Console.Write(j);
                //}
                //Console.WriteLine(" ");
            //}

          
        }

    }
}
