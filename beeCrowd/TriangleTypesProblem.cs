using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class TriangleTypesProblem
    {
        public double TriangleTypes()
        {
            Console.WriteLine("Enter the value a");
            double sideA=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value b");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value c");
            double sideC = Convert.ToDouble(Console.ReadLine());

            if (sideA < sideB)
            {
                double temp = sideA;
                sideA = sideB;
                sideB = temp;
            }

            if (sideB < sideC)
            {
                double temp = sideB;
                sideB = sideC;
                sideC = temp;

                if (sideA < sideB)
                {
                    temp = sideA;
                    sideA = sideB;
                    sideB = temp;
                }
            }
            if(sideA>=sideB+sideC)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if(sideA*sideA==sideB*sideB+sideC*sideC)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if(sideA * sideA > sideB * sideB + sideC * sideC)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if(sideA * sideA < sideB * sideB + sideC * sideC)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if(sideA == sideB && sideB==sideC)
            {
                Console.WriteLine(" TRIANGULO EQUILATERO");
            }
            else if(sideA==sideB || sideB==sideC ||sideA==sideC)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
            Console.ReadLine();
            return sideA; 
        }

    }
}
