﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLabs.Laba3
{ 

    public class Task15
    {
        public static void Solution()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int[] array = new int[n];
            for(var i = 0; i < n; i++)
                array[i] = int.Parse(Console.ReadLine());

        }
    }
}
