﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Problem");
            FindMaxNum.MaxValue(70, 70, 70);
            FindMaxNum.MaxValue(86.92f, 41.171f, 39.6f);
            FindMaxNum.MaxValue("Monkey", "Dog", "Cat");
            Console.ReadLine();
        }
    }
}
