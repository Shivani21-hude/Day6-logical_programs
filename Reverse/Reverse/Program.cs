using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to reverse");
            int n=Convert.ToInt32(Console.ReadLine());
            
            int d=0;
            
            while(0<n)
            {
                int num =  n % 10;
                d= (d * 10) + num;
                n = n / 10;
            }
            Console.WriteLine("The number in reverse order: " + d);
            Console.ReadLine();
        }
    }
}