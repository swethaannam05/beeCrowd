using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class Bhaskara_sFormula
    {
        public double Bhaskar()
        {
            Console.WriteLine("Enetr the Float value a");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enetr the Float value b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enetr the Float value c");
            double c = Convert.ToDouble(Console.ReadLine());

            double root = ((b * b) - (4 * a * c));
            if(a==0||b==0||c==0||root<0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double R1 = (-b + Math.Sqrt(root)) / (2 * a);
                double R2 = (-b - Math.Sqrt(root)) / (2 * a);
                Console.WriteLine("R1 = "+  R1.ToString("F5") + Environment.NewLine  + "R2 = " + R2.ToString("F5"));
                //Console.WriteLine($"Root 1: {root1:F5}");
            }
            Console.ReadLine();
            return a;
        }

    }
}
