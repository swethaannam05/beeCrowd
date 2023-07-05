using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class DistanceCars
    {
        public double CarDistance()
        {
            int carX, carY;
            carX = 60;
            carY = 90;
            Console.WriteLine("enter the distance travelled");
            int dist=Convert.ToInt32(Console.ReadLine());

            int differenceinspeed = carY - carX;
            int timetaken=(dist/differenceinspeed)*60;
            Console.WriteLine("Mintious =" + timetaken);
            Console.ReadLine();
            return timetaken;


            

        }
    }
}
