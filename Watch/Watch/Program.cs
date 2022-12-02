using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for startwatch: ");
             int Start=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter a number for endwatch: ");
             int Stop = Convert.ToInt32(Console.ReadLine());
             Stopwatch stopwatch = new Stopwatch();
             stopwatch.Start();
            stopwatch.Stop();
             Console.WriteLine("Time Elapsed : {0}",
             stopwatch.Elapsed);
            
        }
    
    }
}
