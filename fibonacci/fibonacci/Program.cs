using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int val1 = 0, val2 = 1;
            int val3;

            for (int i = 0; i < n; i++)
            {
                val3 = val1 + val2;
                Console.WriteLine(val3);

                val1 = val2;
                val2 = val3;
            }
        }
    }
}