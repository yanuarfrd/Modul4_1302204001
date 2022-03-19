using System;

namespace MODUL4_1302204001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<float>(22, 40, 13));

        }

    }
    class Penjumlahan
    {
        public static float JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic tempA = a;
            dynamic tempB = b;
            dynamic tempC = c;

            return tempA + tempB + tempC;
        }
    }
}