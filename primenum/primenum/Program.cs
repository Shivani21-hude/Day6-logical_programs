using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number :");
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i <= n; i++)
            {
                bool isPrimeNumber = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }

                }   if (isPrimeNumber)
                {

                    Console.WriteLine(i + "  ");
                }
            }
        }
    }
}