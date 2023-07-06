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
            #region "Coordinate of a point"
            Coordinates_of_a_Point coordinates_Of_A_Point =new Coordinates_of_a_Point();
            coordinates_Of_A_Point.Coordinates();
            #endregion

            #region 
            Average3 average3 = new Average3();
            average3.Averageof3();
            #endregion

            #region "Snack program"
            Snack snack = new Snack();
            snack.Snacks();
            #endregion

            #region "Interval problem"
            Interval interval = new Interval();
            interval.Intervals();
            #endregion

            #region "Bhaskara's Formula"
            Bhaskara_sFormula bhaskara_SFormula = new Bhaskara_sFormula();
            bhaskara_SFormula.Bhaskar();
            #endregion

            #region "Selection Test 1"
            SelectionTest1 selectionTest1 = new SelectionTest1();
            selectionTest1.selectionTest();
            #endregion

            #region "Banknotes and coins"
            BanknotesAndCoins banknotesAndCoins = new BanknotesAndCoins();
            banknotesAndCoins.Coins();
            #endregion

            #region "Age in Days"
            AgeInDays ageInDays =new AgeInDays();
            ageInDays.Age();
            #endregion

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