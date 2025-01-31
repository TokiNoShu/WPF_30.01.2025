using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator2
    {
        public bool X { get; set; }
        public bool Y { get; set; }
        public bool Z { get; set; }


        public Calculator2(bool x, bool y, bool z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public bool CalculateA()
        {
            return X && !(Z || Y) || !Z;
        }
        public bool CalculateB()
        {
            return !X || X && (Y || Z);
        }
        public bool CalculateC()
        {
            return (X || Y && !Z) && Z;
        }
        public void DisplayResults2()
        {
            bool ResultA = CalculateA();
            bool ResultB = CalculateB();
            bool ResultC = CalculateC();

            Console.WriteLine($"A = {ResultA}");
            Console.WriteLine($"B = {ResultB}");
            Console.WriteLine($"C = {ResultC}");
            Console.ReadLine();
        }
    }
}
