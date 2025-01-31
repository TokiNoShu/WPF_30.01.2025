using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator10
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }


        public Calculator10(bool a, bool b, bool c)
        {
            A = a;
            B = b;
            C = c;
        }
        public bool CalculateA()
        {
            return A || !(A &&  B) || C;
        }
        public bool CalculateB()
        {
            return !A || C && !(B || C);
        }
        public bool CalculateC()
        {
            return (A || B && !C) || A;
        }
        public void DisplayResults10()
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
