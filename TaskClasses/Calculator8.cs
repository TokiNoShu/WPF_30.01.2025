using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    internal class Calculator8
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }



        public Calculator8(double x81, double y81, double x82, double y82)
        {
            X1 = x81;
            Y1 = y81;
            X2 = x82;
            Y2 = y82;

        }
        public bool CalculateA()
        {
            return (X1 >= 0) && (Math.Pow(Y1, 2) != 4) ;
        }
        public bool CalculateB()
        {
            return (X2 * Y2 != 0) && (Y2 < X2);
        }
        public void DisplayResults8()
        {
            bool ResultA = CalculateA();
            bool ResultB = CalculateB();

            Console.WriteLine($"A = {ResultA}");
            Console.WriteLine($"B = {ResultB}");
            Console.ReadLine();
        }
    }
}
