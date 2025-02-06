using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    internal class Calculator3
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }



        public Calculator3(double x31, double y31, double x32, double y32)
        {
            X1 = x31;
            Y1 = y31;
            X2 = x32;
            Y2 = y32;

        }
        public bool CalculateA()
        {
            return (!(X1 * Y1 < 0)) && (Y1 > X1);
        }
        public bool CalculateB()
        {
            return (X2 >= 2) || (Math.Pow(Y2, 2) != 5);
        }
        public void DisplayResults3()
        {
            bool ResultA = CalculateA();
            bool ResultB = CalculateB();

            Console.WriteLine($"A = {ResultA}");
            Console.WriteLine($"B = {ResultB}");
            Console.ReadLine();
        }
    }
}
