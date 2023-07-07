using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class TriangleProblem
    {
        public double Triangle()
        {
            Console.WriteLine("Enter the 1st value");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 3rd value");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                double parameter = a + b + c;
                Console.WriteLine("Perimetro =" + parameter.ToString("F1"));
            }
            else
            {
                double area = ((a + b) * c) / 2;
                Console.WriteLine("Area ="+ area.ToString("F1"));
            }
            Console.ReadLine();
            return a;
            
        }
    
    }
}
