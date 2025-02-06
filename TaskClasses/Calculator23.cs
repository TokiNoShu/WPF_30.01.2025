using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.TaskClasses
{
    internal class Calculator23
    {
        public double A { get; set; }

        public Calculator23(double a23)
        {
            A = a23;
        }
        public bool CalculateA()
        {
            return !(A > -10 && A < -1) || !(A > 2 && A < 15);
        }
        public void DisplayResults23()
        {
            bool ResultA = CalculateA();

            Console.WriteLine($"A = {ResultA}");
            Console.ReadLine();
        }
    }
}
