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
            
            StudentGradeAverage avg = new StudentGradeAverage();
            avg.Average();

            Prod prod = new Prod();
            prod.Prod1();

            SomaAdd somaAdd = new SomaAdd();
            somaAdd.SomaAddition();

            Circle circle = new Circle();
            circle.Area();

            ExtreamlyBasic extreamlyBasic = new ExtreamlyBasic();
            extreamlyBasic.A();

            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}