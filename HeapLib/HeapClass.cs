using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeapLib
{
    public class Heap
    {

        private int[] heapArray; //Массив, на основе которого строится куча
        private int heapSizeV = 0; // Размер кучи
        private int heapSizeV2 = 0; // Дубликат размера кучи, нужен для сохранения оригинала в процессе сортировки 

        //Конструктор класса Heap - строит кучу на основе массива a
        public Heap(int[] a)
        {
            HeapSize = a.Length;
            heapArray = new int[a.Length + 1];
            // Переписываем массив a в массив кучи heapArray
            for (int i = 0; i < a.Length; i++)
            {
                heapArray[i + 1] = a[i];
            }
            //Просеиваем все элементы кучи
            HeapSize2 = HeapSize;
            for (int i = HeapSize / 2; i > 0; i--)
            {
                SiftDown(i);
            }
        }

        //Свойства HeapSize и HeapSize2 - размер кучи(и дубликата).
        public int HeapSize
        {
            get
            {
                return heapSizeV;
            }
            set
            {
                if (value >= 0)
                    heapSizeV = value;
            }
        }

        public int HeapSize2
        {
            get
            {
                return heapSizeV2;
            }
            set
            {
                if (value >= 0)
                    heapSizeV2 = value;
            }
        }
        //Предок вершины i 
        private static int Parent(int i)
        {
            return i / 2;
        }

        //Левый потомок вершины i
        private static int Left(int i)
        {
            return 2 * i;
        }

        //Правый потомок вершины i
        private static int Right(int i)
        {
            return 2 * i + 1;
        }


        //Обмен элементов int32
        private static void Swap(ref int a, ref int b)
        {
            int w = a;
            a = b;
            b = w;
        }

        // Просеивание элемента вниз по куче
        private void SiftDown(int i)
        {
            int l = Left(i);
            int r = Right(i);

            int largest;

            //Ищем два максимум из текущего элемента и потомков 
            if (l <= HeapSize && heapArray[l] > heapArray[i])
                largest = l;
            else
                largest = i;

            if (r <= HeapSize && heapArray[r] > heapArray[largest])
                largest = r;

            //Если нужно - опускаем элемент
            if (largest != i)
            {
                Swap(ref heapArray[i], ref heapArray[largest]);
                SiftDown(largest);
            }
        }

        //Сортируем массив на основе кучи
        public void Sort()
        {
            for (int i = HeapSize; i >= 2; i--)
            {
                Swap(ref heapArray[i], ref heapArray[1]);
                HeapSize--;
                SiftDown(1);
            }
            HeapSize = HeapSize2;
        }

        //Преобразование кучи в массив
        public void ToArray(int[] a)
        {
            for (int i = 0; i < HeapSize; i++)
                a[i] = heapArray[i + 1];
        }
    }
}
