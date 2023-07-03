using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class VolumeOfSphere
    {
        public double Sphere()
        {
            double pi = 3.14159;
            Console.WriteLine("Enter the radius of the sphere");
            double radius = Convert.ToInt32(Console.ReadLine());
            double volume=(4.0/3.0)*pi*radius*radius*radius;
            Console.WriteLine("VOLUME ="+ volume.ToString("F3"));
            Console.ReadLine();

            return volume;

        }
    }
}
