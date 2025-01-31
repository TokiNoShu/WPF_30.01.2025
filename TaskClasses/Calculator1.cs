using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator1
    {
        public bool A {  get; set; }
        public bool B { get; set; }
        public bool C { get; set; }


        public Calculator1(bool a, bool b, bool c) 
        {
            A = a;
            B = b;
            C = c;
        }
        public bool CalculateA()
        { 
            return (A || !A && B) || C; 
        }
        public bool CalculateB() 
        {
            return !A || A && (B || C);
        }
        public bool CalculateC() 
        {
            return (A || B && !C) && C;
        }
        public void DisplayResults1() 
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
