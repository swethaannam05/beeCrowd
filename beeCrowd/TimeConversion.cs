using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class TimeConversion
    {
        public double Conversion()
        {
            Console.WriteLine("Enter total time in seconds");
            int timeinsec=Convert.ToInt32(Console.ReadLine());

            DateTime timeSpan = DateTime.MinValue.AddSeconds(timeinsec);
            string time = timeSpan.ToString("hh:mm:ss");
            Console.WriteLine("Time in format" + time);
            Console.ReadLine();

            return timeinsec;
        }
    }
}
