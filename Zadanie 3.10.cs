﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba, silnia = 1;
            Console.WriteLine("Podaj liczbę: ");
            liczba = int.Parse(Console.ReadLine());

            for (int i = 1; i <= liczba; i++)

                silnia *= i;

            Console.WriteLine("Silnia wynosi: ");
            Console.WriteLine(silnia);


            Console.ReadKey();
        }
    }
}
