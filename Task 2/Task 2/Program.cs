﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            for(int i = 0; i <= 100; i++)
            {
                sum =sum+ i;
            }
            Console.WriteLine("The sum of the numbers are:" + sum);
        }
    }
}
