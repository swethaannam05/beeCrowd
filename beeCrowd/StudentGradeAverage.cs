using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    public class StudentGradeAverage
    {
        public double Average()
        {
            Console.WriteLine("Enter grade of student 1");
            double stud1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter grade of student 2");
            double stud2 = Convert.ToDouble(Console.ReadLine());
            double media = (stud1 * 3.5 + stud2 * 7.5) / (3.5 + 7.5);
            Console.WriteLine("MEDIA = " + media.ToString("F5"));
            Console.ReadLine();
            return media;
        }
    }
}
