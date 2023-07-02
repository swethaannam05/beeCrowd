using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class StudentGradeAverage2
    {
        public double Average1()
        {
            Console.WriteLine("Enter grade of student 1");
            double studs1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter grade of student 2");
            double studs2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter grade of student 3");
            double studs3=Convert.ToDouble(Console.ReadLine());
            double medias = (studs1 * 2 + studs2 * 3 + studs3 * 5) / (2 + 3 + 5);
            Console.WriteLine("MEDIAS = " + medias.ToString("F5"));
            Console.ReadLine();
            return medias;

        }
    }
}
