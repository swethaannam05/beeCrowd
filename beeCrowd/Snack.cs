using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class Snack
    {
        public int Snacks()
        {
            //int[] code = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter the code of the item from 1 to 5");
            int code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the qunatity of the item");
            int items = Convert.ToInt32(Console.ReadLine());

            if(code==1)
            {
                double Cachorro = items * 4.00;
                Console.WriteLine("Total $ " + Cachorro.ToString("F2"));
            }
            else if(code==2)
            {
                double X_Salada = items * 4.50;
                Console.WriteLine("Total $ " + X_Salada.ToString("F2"));
            }
            else if (code == 3)
            {
                double X_Bacon = items * 5.00;
                Console.WriteLine("Total $ " + X_Bacon.ToString("F2"));
            }
            else if (code == 4)
            {
                double Toradda = items * 2.00;
                Console.WriteLine("Total $ " + Toradda.ToString("F2"));
            }
            else if (code == 5)
            {
                double Regrigerante = items * 1.50;
                Console.WriteLine("Total $ " + Regrigerante.ToString("F2"));
            }
            Console.ReadLine();

            return code;

        }
    }
}
