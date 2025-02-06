using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    internal class Calculator22
    {
        public double X;
        public double Y;

        public Calculator22(double x22, double y22)
        {
            X = x22;
            Y = y22;
        }
        public bool CalculateA()
        {
            return !(X <= -5) && X > 5;
        }
        public bool CalculateB()
        {
            return -3.5 < Y && Y <= 8.1 && X != 0;
        }
        public void DisplayResults22()
        {
            Console.WriteLine($"A = {CalculateA()}");
            Console.WriteLine($"B = {CalculateB()}");
            Console.ReadLine();
        }
    }
}