using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class SomaAdd
    {
        public double SomaAddition()
        {
            Console.WriteLine("Enter number1");
            double a1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number2");
            double a2=Convert.ToDouble(Console.ReadLine());
            double soma=a1+a2;
            Console.WriteLine("SOMA="+ soma);
            Console.ReadLine();
            return soma;
        }
    }
}
