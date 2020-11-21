﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = rand.Next(1, 25);
            int[] tab1 = new int[x];
            int[] tab2 = new int[x];
            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = rand.Next(1, 1024);
            }
            for (int i = 0; i < tab2.Length; i++)
            {
                if (i + 1 == tab2.Length)
                {
                    tab2[0] = tab1[i];
                }
                else
                {
                    tab2[i + 1] = tab1[i];
                }
            }
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("tab[{1}] = {0,4}", tab1[i], i);
            }
            Console.WriteLine("");
            for (int i = 0; i < tab2.Length; i++)
            {
                Console.WriteLine("tab2[{1}] = {0,4}", tab2[i], i);
            }
            Console.ReadKey();
        }
    }
}
