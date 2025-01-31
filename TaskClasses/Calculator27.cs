using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator27
    {
        public double X;
        public double Y;

        public Calculator27(double x27, double y27)
        {
            X = x27;
            Y = y27;
        }
        public bool CalculateA()
        {
            return X > 3 || X < -1;
        }
        public bool CalculateB()
        {
            return -4 < Y && Y <= 2 && X > 0;
        }
        public void DisplayResults27()
        {
            Console.WriteLine($"A = {CalculateA()}");
            Console.WriteLine($"B = {CalculateB()}");
            Console.ReadLine();
        }
    }
}