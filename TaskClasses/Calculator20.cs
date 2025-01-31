using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator20
    {
        public double X;

        public Calculator20(double x20)
        {
            X = x20;
        }
        public double CalculateA()
        {
            return 1 - Math.Cos(3 * X);
        }
        public double CalculateB()
        {
            return X / Math.Pow(X - 3, 2);
        }
        public void DisplayResults20()
        {
            Console.WriteLine($"Область определения = {CalculateA()} : {CalculateB()}");
            Console.ReadLine();
        }
    }
}