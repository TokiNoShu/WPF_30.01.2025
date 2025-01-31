using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator4
    {
        public double A { get; set; }


        public Calculator4(double a4)
        {
            A = a4;
        }
        public bool CalculateA()
        {
            return A % 2 == 0 || A % 3 == 0;
        }
        public void DisplayResults4()
        {
            bool ResultA = CalculateA();

            Console.WriteLine($"A = {ResultA}");
            Console.ReadLine();
        }
    }
}
