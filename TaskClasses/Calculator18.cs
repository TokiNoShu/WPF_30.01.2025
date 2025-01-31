using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator18
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }


        public Calculator18(bool a, bool b, bool c)
        {
            A = a;
            B = b;
            C = c;
        }
        public bool CalculateA()
        {
            return A && !B || C;
        }
        public bool CalculateB()
        {
            return A && (!B || C);
        }
        public bool CalculateC()
        {
            return A || (!(B && C));
        }
        public void DisplayResults18()
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
