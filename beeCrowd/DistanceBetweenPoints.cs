using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class DistanceBetweenPoints
    {
        public double Distance()
        {
            double x1, x2, y1, y2;
           // Console.WriteLine("Enter the value x1");
            x1= double.Parse(Console.ReadLine());
           // Console.WriteLine("Enter the value for x2");
            x2= double.Parse(Console.ReadLine());
           // Console.WriteLine("Enter the value for y1");
            y1= double.Parse(Console.ReadLine());
           // Console.WriteLine("Enter the value for y2");
            y2= double.Parse(Console.ReadLine());

            double dist=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
           //double dist=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
            Console.WriteLine("Distance = "+ dist.ToString("F2"));
            Console.ReadLine();
            return dist;

        }
    }
}
