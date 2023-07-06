using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class SelectionTest1
    {
        public int selectionTest()
        {
            Console.WriteLine("Enter the value for A");
            int A=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for C");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for D");
            int D = Convert.ToInt32(Console.ReadLine());

            //int 5 6 7 8
            if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

            //if (B > C && D > A)
            //{
            //    int sum1 = C + D;
            //    int sum2 = A + B;
            //    if (sum1 > sum2)
            //    {
            //        A % 2 == 0;
            //        C > 0;
            //        d > 0;
            //        Console.WriteLine("Valores aceitos");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Valores nao aceitos");
            //}
            Console.ReadLine();
            return A;
        }
    }
}
