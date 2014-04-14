using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeapLib;

namespace SortLib
{
    public class Sort
    {
        /// <summary>
        /// Обмен двух элементов типа int.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void Swap(ref int a, ref int b)
        {
            int w = a;
            a = b;
            b = w;
        }

        /// <summary>
        /// Пирамидальная сортировка.
        /// </summary>
        /// <param name="arr">Массив для сортировки.</param>
        public static void HeapSort(int[] arr)
        {
            Heap heap = new Heap(arr);
            heap.Sort();
            heap.ToArray(arr);
        }

        /// <summary>
        /// Пузырьковая сортировка.
        /// </summary>
        /// <param name="arr">Массив для сортировки.</param>
        public static void BubbleSort(int[] arr)
        {
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j]) Swap(ref arr[i], ref arr[j]);
            //    }
            //}

            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < arr.Length - 1; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Быстрая сортировка[для вывода]
        /// </summary>
        /// <param name="arr">Массив для сортировки.</param>
        public static void QuickSort(int[] arr)
        {
            QSort(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// Быстрая сортировка[реализация]
        /// </summary>
        /// <param name="arr">Массив для сортировки.</param>
        /// <param name="first">Левая граница.</param>
        /// <param name="last">Правая граница.</param>
        static void QSort(int[] arr, int first, int last)
        {
            int i = first;
            int j = last;
            int x = arr[(first + last) / 2];
            do
            {
                while (arr[i] < x)
                    i++;
                while (arr[j] > x)
                    j--;
                if (i <= j)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (first < j)
                QSort(arr, first, j);
            if (i < last)
                QSort(arr, i, last);
        }
    }
}