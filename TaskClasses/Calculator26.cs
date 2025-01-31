using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator26
    {
        public double X;
        public double Y;

        public Calculator26(double x26, double y26)
        {
            X = x26;
            Y = y26;
        }
        public bool CalculateA()
        {
            return !(X > 0) && X < 5;
        }
        public bool CalculateB()
        {
            return 0 < Y && Y <= 6 && X < 7;
        }
        public void DisplayResults26()
        {
            Console.WriteLine($"A = {CalculateA()}");
            Console.WriteLine($"B = {CalculateB()}");
            Console.ReadLine();
        }
    }
}