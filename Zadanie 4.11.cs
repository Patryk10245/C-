﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj słowo.");
            string x = Console.ReadLine();
            while (x.Length > 0)
            {
                Console.Write(x[0] + " = ");
                int y = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[0] == x[i])
                    {
                        y++;
                    }
                }
                Console.WriteLine(y);
                x = x.Replace(x[0].ToString(), string.Empty);
            }
            Console.ReadKey();
        }
    }
}
