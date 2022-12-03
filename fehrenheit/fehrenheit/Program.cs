using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fehrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the fehrenheit value: ");
            double F=Convert.ToInt32(Console.ReadLine());
            double Cel = ((F - 32) * 5 / 9);
            Console.WriteLine("{0} Fehrenheit value to celcius value is {1}",F, Cel);
        }
    }
}