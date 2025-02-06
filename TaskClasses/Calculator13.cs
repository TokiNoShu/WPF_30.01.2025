using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    internal class Calculator13
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Calculator13(double a13, double b13, double c13)
        {
            A = a13;
            B = b13;
            C = c13;
        }
        public bool CalculateA()
        {
            return A < 45 ^ B < 45 ^ C < 45;
        }
        public void DisplayResults13()
        {
            bool ResultA = CalculateA();

            Console.WriteLine($"A = {ResultA}");
            Console.ReadLine();
        }
    }
}
