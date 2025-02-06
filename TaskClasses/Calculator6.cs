using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    internal class Calculator6
    {
        public bool X { get; set; }
        public bool Y { get; set; }
        public bool Z { get; set; }


        public Calculator6(bool x, bool y, bool z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public bool CalculateA()
        {
            return X || Y && !Z;
        }
        public bool CalculateB()
        {
            return !X && !Y;
        }
        public bool CalculateC()
        {
            return !(X && Z) || Y;
        }
        public void DisplayResults6()
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
