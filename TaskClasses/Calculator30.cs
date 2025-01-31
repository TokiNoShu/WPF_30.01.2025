using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator30
    {
        public double X;

        public Calculator30(double x30)
        {
            X = x30;
        }
        public bool CalculateA()
        {
            return X != 0;
        }
        public void DisplayResults30()
        {
            Console.WriteLine($"A = {CalculateA()}");
            Console.ReadLine();
        }
    }
}