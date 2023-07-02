using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace beeCrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "student Grade Average of 3 "
            StudentGradeAverage2 avg1 = new StudentGradeAverage2();
            avg1.Average1();
            #endregion

            #region "student Grade Average of 2 "
            StudentGradeAverage avg = new StudentGradeAverage();
            avg.Average();
            #endregion

            #region "Sum problem with output prod"
            Prod prod = new Prod();
            prod.Prod1();
            #endregion

            #region "Addtion with output soma"
            SomaAdd somaAdd = new SomaAdd();
            somaAdd.SomaAddition();
            #endregion

            #region "Area of circle"
            Circle circle = new Circle();
            circle.Area();
            #endregion

            #region "Addition problem"
            ExtreamlyBasic extreamlyBasic = new ExtreamlyBasic();
            extreamlyBasic.A();
            #endregion

            #region "HEllo world program"
            Console.WriteLine("Hello World");
            Console.ReadLine();
            #endregion
        }
    }
}