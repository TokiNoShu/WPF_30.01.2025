using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    internal class Calculator15
    {
        public double A { get; set; }

        public Calculator15(double a15)
        {
            A = a15;
        }
        public bool CalculateA()
        {
            return (A > -137 && A < -51) || (A > 55 && A < 123);
        }
        public void DisplayResults15()
        {
            bool ResultA = CalculateA();

            Console.WriteLine($"A = {ResultA}");
            Console.ReadLine();
        }
    }
}
