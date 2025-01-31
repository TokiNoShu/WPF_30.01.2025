using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator5
    {
        public double A { get; set; }
        public double B { get; set; }


        public Calculator5(double a5, double b5)
        {
            A = a5;
            B = b5;
        }
        public bool CalculateA()
        {
            return A % 2 == 0 && B % 2 == 0;
        }
        public void DisplayResults5()
        {
            bool ResultA = CalculateA();

            Console.WriteLine($"A = {ResultA}");
            Console.ReadLine();
        }
    }
}
