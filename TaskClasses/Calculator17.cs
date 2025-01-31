using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator17
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Calculator17(double x17, double y17, double z17)
        {
            X = x17;
            Y = y17;
            Z = z17;
        }
        public bool CalculateA()
        {
            return X > 80 || Y > 80 || Z > 80;
        }
        public void DisplayResults17()
        {
            bool ResultA = CalculateA();

            Console.WriteLine($"A = {ResultA}");
            Console.ReadLine();
        }
    }
}
