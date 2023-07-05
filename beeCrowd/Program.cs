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
            #region "timeConversion"
            TimeConversion timeConversion = new TimeConversion();
            timeConversion.Conversion();
            #endregion

            #region "Bank notes problem"
            BankNotes bankNotes = new BankNotes();
            bankNotes.Notes();
            #endregion

            #region "Fuel spent"
            FuelSpent fuelSpent = new FuelSpent();
            fuelSpent.Fuel();
            #endregion

            #region "Distance of cars"
            DistanceCars distanceCars = new DistanceCars();
            distanceCars.CarDistance();
            #endregion

            #region "Distance between two points"
            DistanceBetweenPoints distanceBetweenPoints = new DistanceBetweenPoints();
            distanceBetweenPoints.Distance();
            #endregion

            #region "Car's average consumption fuel per km"
            Consumption consumption = new Consumption();
            consumption.AverageConsumption();
            #endregion

            #region "The greatest number"
            TheGreatest theGreatest = new TheGreatest();
            theGreatest.Greatest();
            #endregion

            #region "area of shapes"
            AreaOfShapes areaOfShapes = new AreaOfShapes();
            areaOfShapes.Area();
            #endregion

            #region "Volume of Sphere"
            VolumeOfSphere volumeOfSphere = new VolumeOfSphere();
            volumeOfSphere.Sphere();
            #endregion

            #region "Simple Calculation problem"
            SimpleCalculate simpleCalculate = new SimpleCalculate();
            simpleCalculate.Calculate();
            #endregion

            #region "Salary with bonus problem"
            SalaryWithBonus salaryWithBonus = new SalaryWithBonus();
            salaryWithBonus.SalaryBonus();
            #endregion

            #region "Salary problem"
            Salary salary =new Salary();
            salary.Salaries();
            #endregion

            #region "Difference problem"
            Difference difference = new Difference();
            difference.Differenca();
            #endregion 

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