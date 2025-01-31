using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator9
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }



        public Calculator9(double x91, double y91, double x92, double y92)
        {
            X1 = x91;
            Y1 = y91;
            X2 = x92;
            Y2 = y92;

        }
        public bool CalculateA()
        {
            return (!(X1 * Y1 < 0)) || (Y1 > X1);
        }
        public bool CalculateB()
        {
            return (X2 * Y2 != 0) && (Y2 > X2);
        }
        public void DisplayResults9()
        {
            bool ResultA = CalculateA();
            bool ResultB = CalculateB();

            Console.WriteLine($"A = {ResultA}");
            Console.WriteLine($"B = {ResultB}");
            Console.ReadLine();
        }
    }
}
