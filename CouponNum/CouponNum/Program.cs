using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CouponNum
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter as NumberFormatInfo to print random numbers");
            int n=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                Random random = new Random();
                string result = new string(
                    Enumerable.Repeat(chars, 9).Select(s => s[random.Next(s.Length)]).ToArray());
                Console.WriteLine(result);
            }
            

        }

    }
}