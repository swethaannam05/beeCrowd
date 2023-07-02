using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class ExtreamlyBasic
    {
        public int A() 
        {

            Console.WriteLine("Enter value for a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b");
            int b = Convert.ToInt32(Console.ReadLine());
            int x = a + b;
            Console.WriteLine("the value is X=" + x);
            Console.WriteLine("Soma="+ x);
            Console.ReadLine();
            return x;



        }
       

    }
}
