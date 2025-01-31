using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator7
    {
        public double X;

        public Calculator7(double x7)
        {
            X = x7;
        }
        public bool CalculateA()
        {
            return Math.Cos(X) != 0;
        }
        public bool CalculateB()
        {
            return X != 1;
        }
        public void DisplayResults7()
        {
            Console.WriteLine($"A = {CalculateA()}");
            Console.WriteLine($"B = {CalculateB()}");
            Console.ReadLine();
        }
    }
}