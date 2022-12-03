using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryfun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Decimal Number : ");
           int i = Convert.ToInt32(Console.ReadLine());

            i =(((i&0x0F)<<4)|((i&0xF0)>>4));
            
            Console.Write("Swpping of two nibbles:"+ i);
        }
    }
}