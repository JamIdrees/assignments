﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.WriteLine("enter value of n:");
            n = int.Parse(Console.ReadLine());
            for (i = n; i >= 1; i--)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}