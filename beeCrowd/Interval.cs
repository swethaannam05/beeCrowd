using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class Interval
    {
        public double Intervals()
        {
            Console.WriteLine("Enetr a floating point");
            double number=Convert.ToDouble(Console.ReadLine());
            string range;
           if(number>=0 && number<=100)
            {
                switch ((int)number/25)
                {
                    case 0: 
                        range = "Intervalo [0,25]";
                        break;
                    case 1: range = "Intervalo (25,50]";
                        break;
                    case 2: range = "Intervalo (50,75]";
                        break;
                    case 3: range = "Intervalo (75,100]";
                        break;
                    default:range = "Out of Interval";
                        break;
                }
                Console.WriteLine(range);
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
           
           Console.ReadLine();
            return number;
        }
    }
}
