using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    internal class Calculator19
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }


        public Calculator19(bool a, bool b, bool c)
        {
            A = a;
            B = b;
            C = c;
        }
        public bool CalculateA()
        {
            return (!A || !B) && !C;
        }
        public bool CalculateB()
        {
            return (!A || !B) && (A || B);
        }
        public bool CalculateC()
        {
            return A && B || A && C || !C;
        }
        public void DisplayResults19()
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
