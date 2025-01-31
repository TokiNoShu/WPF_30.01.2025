using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator24
    {
        public double A { get; set; }

        public Calculator24(double a24)
        {
            A = a24;
        }
        public bool CalculateA()
        {
            return A <= 9999 && A >= 1000 && A != 4999 && A % 1 == 0;
        }
        public void DisplayResults24()
        {
            bool ResultA = CalculateA();

            Console.WriteLine($"A = {ResultA}");
            Console.ReadLine();
        }
    }
}
