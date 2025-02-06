using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    internal class Calculator21
    {
        public bool X { get; set; }
        public bool Y { get; set; }
        public bool Z { get; set; }


        public Calculator21(bool x, bool y, bool z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public bool CalculateA()
        {
            return (X && !Y) || Z;
        }
        public bool CalculateB()
        {
            return X && (!Y || Z);
        }
        public bool CalculateC()
        {
            return X || (!(Y || Z));
        }
        public void DisplayResults21()
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
