using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    internal class Calculator11
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }



        public Calculator11(double x111, double y111, double x112, double y112)
        {
            X1 = x111;
            Y1 = y111;
            X2 = x112;
            Y2 = y112;

        }
        public bool CalculateA()
        {
            return (!(X1 * Y1 < 1)) && (Y1 > X1);
        }
        public bool CalculateB()
        {
            return (X2 * Y2 != 0) || (Y2 > X2);
        }
        public void DisplayResults11()
        {
            bool ResultA = CalculateA();
            bool ResultB = CalculateB();

            Console.WriteLine($"A = {ResultA}");
            Console.WriteLine($"B = {ResultB}");
            Console.ReadLine();
        }
    }
}
