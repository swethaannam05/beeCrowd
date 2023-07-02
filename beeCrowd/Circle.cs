using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class Circle
    {
        public double Area()
        {
            double n = 3.14159;
            Console.WriteLine("Enter the radius of the circle");
            double r = Convert.ToDouble(Console.ReadLine());
            double area = n * r * r;
            Console.WriteLine("Area of the circle is" + area);
            Console.ReadLine();
            return area;
            
        }

    }
}
