﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Zjadłbym c i a s t k o, choć nie mam ciastka, ale zjadłbym c i a s t k o, więc chce kupić c i a s t k o, by zjeść c i a s t k o";
            int counter = 0;
            int index = 0;

            while (index < text.Length && char.IsWhiteSpace(text[index]))
            {
                index++;
            }
            while (index < text.Length)
            {
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                {
                    index++;
                }
                counter++;
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                {
                    index++;
                }
            }
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
