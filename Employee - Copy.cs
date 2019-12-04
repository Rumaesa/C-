using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstproject
{
    class Employee
    {
        public static void Main()
        {
            Employee obj = new Employee();
            obj.calbonus();
        }   

    public int calsal()
    {
        Console.WriteLine("enter salary of an employee :");
        int sal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter number of days :");
        int day = Convert.ToInt32(Console.ReadLine());
        int takehomesal = (sal + day) / 30;
        return takehomesal;

    }
    public void calbonus()
    {
        int sal=calsal();
        Console.WriteLine("this month salary is :" +sal);
        int bonus=(sal*10)/100;
        Console.WriteLine("the bonus is :" +bonus);
        Console.WriteLine("this month salary with bonus is :" +(sal +bonus));
    }


    }
}
