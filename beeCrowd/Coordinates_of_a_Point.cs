using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class Coordinates_of_a_Point
    {
        public double Coordinates()
        {
            Console.WriteLine("enter the Coordinate of x axis");
            double x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the Coordinate of y axis");
            double y = Convert.ToDouble(Console.ReadLine());

            if(x==0 && y==0)
            {
                Console.WriteLine("Origem");
            }
            else if(x==0 && y!=0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if(x!=0 && y==0)
            {
                Console.WriteLine("Exio X");
            }
            else if(x>0 && y>0)
            {
                Console.WriteLine("Q1");
            }
            else if(x<0 && y>0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else 
            {
                Console.WriteLine("Q4");
            }


            Console.ReadLine();
            return x;
        }
    }
}
