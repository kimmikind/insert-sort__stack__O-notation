using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    static class Sort
    {
        public static void InsertionSort(ref Stack<int> stack)
        {
            InsertionSort(ref stack, stack.Length());
        }
        //сортировка вставками
        private static void InsertionSort(ref Stack<int> stack, int length)
        {
            for (int i = 1; i < length; i++)
            {
                int j = i - 1;
                while ((j >= 0) && (stack.ElementAt(j) > stack.ElementAt(j + 1)))
                {
                    stack.SwapElements(j, j + 1);
                    j--;
                }
            }
        }
    }
}
