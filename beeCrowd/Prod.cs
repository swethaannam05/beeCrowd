using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class Prod
    {
        public int Prod1() 
        {
            Console.WriteLine("enter a number");
            int sum1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int sum2=Convert.ToInt32(Console.ReadLine());
            int prod=sum1+sum2;
            Console.WriteLine("PROD=" + prod);
            Console.ReadLine();
            return prod;
        }

    }
}
