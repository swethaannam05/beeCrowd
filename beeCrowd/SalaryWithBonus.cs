using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class SalaryWithBonus
    {
        public double SalaryBonus()
        {
            Console.WriteLine("What's the name of the Seller?");
            string seller=Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is the salary of this Seller?");
            double fixedsalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sales made in a month");
            double sales=Convert.ToDouble(Console.ReadLine());
            double commision = sales*0.15;
            double totalsalary = commision + fixedsalary;
            Console.WriteLine("TOTAL = "+ totalsalary.ToString("F2"));
            Console.ReadLine();

            return totalsalary;
        }
    }
}
