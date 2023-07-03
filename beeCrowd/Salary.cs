using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class Salary
    {
        public double Salaries()
        {
            Console.WriteLine("Enter the Employee's number");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of hours worked in a month");
            int hrs=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Whats the salary amount per hour");
            double amt=Convert.ToDouble(Console.ReadLine());
            double sal=hrs*amt;
            Console.WriteLine("Number = "+ num);
            Console.WriteLine("SALARY = $ "+ sal.ToString("F2"));
            Console.ReadLine();

            return sal;
        }
    }
}
