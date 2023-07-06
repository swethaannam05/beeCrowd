using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class Average3
    {
        public double Averageof3()
        {
            Console.WriteLine("Enter 1st number");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 4th number");
            double num4 = Convert.ToDouble(Console.ReadLine());

            double media = (num1 * 2 + num2 * 3 + num3 * 4 + num4 * 1) / (2 + 3 + 4 + 1);
            Console.WriteLine("MEDIA = "+ media.ToString("F1"));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado");
            }
            else if(media > 5.0 && media < 6.9)
            {

                Console.WriteLine("Aluno em exame");

                Console.WriteLine("Enter the 5th number");
                double num5=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + num5);
                double media1 = (media + num5) / 2;
                Console.WriteLine("Aluno aprovado");
                if(media1>=5.0||media1<=4.9)
                {
                    Console.WriteLine("Media final: " + media1.ToString("F1"));
                }

            }

            Console.ReadLine();
            return media;
        }
    }
}
