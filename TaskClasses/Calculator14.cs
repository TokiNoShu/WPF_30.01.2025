using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator14
    {
        public double A { get; set; }

        public Calculator14(double a14)
        {
            A = a14;
        }
        public bool CalculateA()
        {
            return A % 3 != 0 && A % 10 == 0;
        }
        public void DisplayResults14()
        {
            bool ResultA = CalculateA();

            Console.WriteLine($"A = {ResultA}");
            Console.ReadLine();
        }
    }
}
