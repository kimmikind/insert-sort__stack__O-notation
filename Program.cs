using System;
using System.Diagnostics;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsNum = 3000;
            for (int i = 0; i < 10; i++)
            {
                long time = TestInsertionSort(elementsNum);
                Console.WriteLine($"Номер сортировки: {i}," +
                                  $"\tКоличество элементов: {elementsNum}," +
                                  $"\tВремя сортировки (ms): {time}");
                elementsNum += 3000;
            }

            Console.Write("Press any key to exit");
            Console.ReadKey();
        }

        private static long TestInsertionSort(int elementsNum)
        {
            Stack<int> stack = new Stack<int>();
            Random random = new Random();
            for (int i = 0; i < elementsNum; i++)
                stack.Push(random.Next(Int32.MaxValue));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Sort.InsertionSort(ref stack);
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
}
