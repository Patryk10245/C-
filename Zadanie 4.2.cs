﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = { -4, -1, -8, 2, 5, 3, 11, -18, 7, 0 };
            int[] tab2 = new int[10];

            int counter = 0;

            for (var i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] > 0)
                {
                    tab2[counter++] = tab1[i];
                }
            }
            for (var y = 0; y < tab2.Length; y++)
            {
                if (tab2[y] != 0) { Console.WriteLine(tab2[y]); }
            }
            Console.ReadKey();
        }
    }
}
