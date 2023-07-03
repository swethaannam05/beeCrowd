using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class SimpleCalculate
    {
        public float Calculate() 
        {
            Console.WriteLine("Enter the code of product 1");
            int prod1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of u its of product 1");
            int unit1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price for 1 unit of the product1");
            float price1=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the code of product 2");
            int prod2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of u its of product 2");
            int unit2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price for 1 unit of the product2");
            float price2 = Convert.ToSingle(Console.ReadLine());
            float totalamount=(unit1 * price1) + (unit2 * price2);
            Console.WriteLine("VALOR A PAGAR = "+ totalamount.ToString("F2"));
            Console.ReadLine();

            return totalamount;

        }
    }
}
