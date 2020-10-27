using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            Console.WriteLine("Podaj temperature w stopniach Celsjusza");
            C = double.Parse(Console.ReadLine());
            F = (C * 9 / 5) + 32;
            Console.WriteLine("Temperatura w stopniach Fahrenheita wynosi: ");
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}
