using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    internal class Calculator28
    {
        public double X;

        public Calculator28(double x28)
        {
            X = x28;
        }
        public bool CalculateA()
        {
            return X != 3;
        }
        public void DisplayResults28()
        {
            Console.WriteLine($"A = {CalculateA()}");
            Console.ReadLine();
        }
    }
}