using System;

namespace MODUL4_1302204001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<float>(22, 40, 13));
            SimpleDataBase<int> objData = new SimpleDataBase<int>();
            objData.AddNewData(12, DateTime.Now);
            objData.AddNewData(34, DateTime.Now);
            objData.AddNewData(56, DateTime.Now);
            objData.PrintAllData();
            Console.ReadKey();

        }

    }
    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic tempA = a;
            dynamic tempB = b;
            dynamic tempC = c;

            return tempA + tempB + tempC;
        }
    }

    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }
        public void AddNewData(T dataBaru, DateTime dataDate)
        {
            storedData.Add(dataBaru);
            inputDates.Add(dataDate);
        }
        public void PrintAllData()
        {
            foreach (T Data in storedData)
            {
                Console.WriteLine("Data 1 berisi: "+ Data);
               
            }
            foreach (DateTime DataDate in inputDates)
            {
                Console.WriteLine("yang disimpan pada waktu:" + DataDate);
            }
        }
    }
}