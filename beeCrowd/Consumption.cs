using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class Consumption
    {
        public double AverageConsumption()
        {
            Console.WriteLine("Enter the distance traveled");
            double distance=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the total fuel consumed");
            double fuel=Convert.ToDouble(Console.ReadLine());
            double averageConsumption=distance/fuel;
            Console.WriteLine(averageConsumption.ToString("F3") + " " + "km/l");
            Console.ReadLine();

            return averageConsumption;
        }
    }
}
