using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class TheGreatest
    {
        public double Greatest()
        {
            Console.WriteLine("Enter the value A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value C");
            int C = Convert.ToInt32(Console.ReadLine());
            //short way
            //int A =int.Parse(Console.ReadLine());
            //int B =int.Parse(Console.ReadLine());
            //int C =int.Parse(Console.ReadLine());

            int greatest = (A > B) ? ((A > C) ? A : C) : ((B > C) ? B : C);
            //int greatest = Math.Max(A, Math.Max(B, C));
            Console.WriteLine(greatest + "eh o maior");
            Console.ReadLine();

            //int maxnumber = ((A + B) + Math.Abs(A - B)) / 2;
            //Console.WriteLine(maxnumber  +" " + "eh o maior");
            //Console.ReadLine();

           // return maxnumber;
           return greatest;
        }

      
    }
}
