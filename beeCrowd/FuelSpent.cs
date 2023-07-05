using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class FuelSpent
    {
        public double Fuel()
        {
            int fuelspent = 12;//km/l
            Console.WriteLine("Enter the timee spent");
            int time=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the average speed of the car");
            int speed=Convert.ToInt32(Console.ReadLine());

            double dist = speed*time;
            double fuelneeded = dist/fuelspent;
            Console.WriteLine("Fuel Needed = " + fuelneeded.ToString("F3"));
            Console.ReadLine();
            return fuelneeded;
            

        }
    }
}
