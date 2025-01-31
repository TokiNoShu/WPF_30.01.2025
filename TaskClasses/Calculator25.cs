using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator25
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public Calculator25(double a25, double b25, double c25, double d25)
        {
            A = a25;
            B = b25;
            C = c25;
            D = d25;
        }
        public bool CalculateA()
        {
            return A / B > C / D;
        }
        public void DisplayResults25()
        {
            bool ResultA = CalculateA();
            if (ResultA)
                Console.WriteLine("1 дробь больше");
            else if (!ResultA && A / B == C / D)
                Console.WriteLine("Дроби Равны");
            else if (!ResultA)
                Console.WriteLine("2 дробь больше");

            Console.ReadLine();
        }
    }
}
