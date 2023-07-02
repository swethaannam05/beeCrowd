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
            
            Console.WriteLine("Hello World");
            Console.ReadLine();

            ExtreamlyBasic extreamlyBasic= new ExtreamlyBasic();
            extreamlyBasic.A();

            Circle circle = new Circle();
            circle.Area();

            SomaAdd somaAdd= new SomaAdd();
            somaAdd.SomaAddition();

        }
    }
}