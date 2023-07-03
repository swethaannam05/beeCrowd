using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class AreaOfShapes
    {
        public double Area()
        {
            double pi = 3.14159;
            Console.WriteLine("Enetr the value A");
            float A=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enetr the value B");
            float B = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enetr the value C");
            float C = Convert.ToSingle(Console.ReadLine());

            //short way
            //float A=float.Parse(Console.ReadLine());
            //float B=float.Parse(Console.ReadLine());
            //float C=float.Parse(Console.ReadLine());

            double areaofrectangledtriangle = (A * C / 2.0) ;
            double areaofcircle = pi * C*C;
            double areaoftrapezium = ((A + B) / 2.0) * C;
            double areaofsquare = B * B;
            double areaofrectangle = A * B;

            Console.WriteLine("TRANGULO = "+ areaofrectangledtriangle.ToString("F3"));
            Console.WriteLine("CIRCULO ="+ areaofcircle.ToString("F3"));
            Console.WriteLine("TRAPEZIO ="+ areaoftrapezium.ToString("F3"));
            Console.WriteLine("QUADRADO =" + areaofsquare.ToString("F3"));
            Console.WriteLine("RECUANGULO ="+ areaofrectangle.ToString("F3"));
            Console.ReadLine();

            return areaofrectangledtriangle;
            
        }
    }
}
