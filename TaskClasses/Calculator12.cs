using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator12
    {
        public double A { get; set; }

        public Calculator12(double a12)
        {
            A = a12;
        }
        public bool CalculateA()
        {
            return A >= 100 && A <= 999 && A % 1 == 0;
        }
        public void DisplayResults12()
        {
            bool ResultA = CalculateA();

            Console.WriteLine($"A = {ResultA}");
            Console.ReadLine();
        }
    }
}
