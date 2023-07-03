using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class Difference
    {
        public int Differenca() 
        {
            Console.WriteLine("Enter the value a");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value d");
            int d = Convert.ToInt32(Console.ReadLine());
            int diff=(a*b-c*d);
            Console.WriteLine("DIFFERENCA = "+ diff);
            Console.ReadLine();

            return diff;


        }
    }
}
