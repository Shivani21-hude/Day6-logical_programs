﻿using System;
namespace decimalcon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Decimal Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for (i = 0; number > 0; i++)
            {
                numberArray[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }
            Console.ReadKey();
        }
    }
}