using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class MultiplesProblem
    {
        public int Multiples()
        {
            Console.WriteLine("Enetr 1st value ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr 2nd value ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a%b==0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
            Console.ReadLine();
            return a;
        }
    }
}
