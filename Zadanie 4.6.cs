﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[5, 5];
            int suma = 0;
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    tab[i, y] = rand.Next(1, 100);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("");
                for (int y = 0; y < 5; y++)
                {

                    if (i == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0,5}", tab[i, y]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("{0,5}", tab[i, y]);
                    }
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < 5; i++)
            {
                suma += tab[i, i];
            }
            Console.WriteLine("Suma elementów na przekątnej jest równa {0}", suma);
            Console.ReadKey();
        }
    }
}
