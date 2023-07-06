using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class SimpleSort
    {
        public int Sort()
        {
            Console.WriteLine("Enter number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int small, middle, large;

            if (num1 <= num2 && num1 <= num3)
            {
                small = num1;
                if(num2<=num3)
                {
                    middle = num2;
                    large = num3;
                }
                else
                {
                    middle = num3;
                    large = num2;
                }
            }

            else if (num2 <= num1 && num2 <= num3)
            {
                small = num2;
                if (num1 <= num3)
                {
                    middle = num1;
                    large = num3;
                }
                else
                {
                    middle = num3;
                    large = num1;
                }
            }
            else
            {
                small = num3;
                if (num1 <= num2)
                {
                    middle = num1;
                    large = num2;
                }
                else
                {
                    middle = num2;
                    large = num1;
                }
            }
           
            Console.WriteLine(small);
            Console.WriteLine(middle);
            Console.WriteLine(large);

            Console.WriteLine();

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.ReadLine();
            return num1;
        }
    }
}
