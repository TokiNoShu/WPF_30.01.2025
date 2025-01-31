using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator16
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Calculator16(double x16, double y16, double z16)
        {
            X = x16;
            Y = y16;
            Z = z16;
        }
        public bool CalculateA()
        {
            return X % 5 == 0 ^ Y % 5 == 0 ^ Z % 5 == 0;
        }
        public void DisplayResults16()
        {
            bool ResultA = CalculateA();

            Console.WriteLine($"A = {ResultA}");
            Console.ReadLine();
        }
    }
}
