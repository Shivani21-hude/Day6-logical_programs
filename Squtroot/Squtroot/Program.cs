using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squtroot
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to compute the square root of a nonnegative number c: ");
            double c=Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;

            }
            Console.WriteLine("Print out the estimate of the suuare root of c: " + t);
        }
    }
}