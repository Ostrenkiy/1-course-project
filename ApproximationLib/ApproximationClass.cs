using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApproximationLib
{
    public class ApproximationClass
    {
        /// <summary>
        /// Считает суммы всех элементов в какой-то степени(от 0 до k включительно)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="k"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static double[] CountSums(double[] x, int k, int n)
        {
            double[] sums = new double[k + 1];
            double[] curX = new double[n];
            for (int i = 0; i < n; i++)
            {
                curX[i] = 1;
            }
            for (int i = 0; i <= k; i++)
            {
                double cSum = 0;
                for (int j = 0; j < n; j++)
                {
                    cSum += curX[j];
                    curX[j] *= x[j];
                }
                sums[i] = cSum;
            }
            return sums;
        }

        /// <summary>
        /// Преобразует табличные данные в матрицу по формуле
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="n"></param>
        /// <returns></returns>

        public static double[,] ReadMatrix(double[] x, double[] y, int n)
        {
            double[,] a = new double[n, n + 1];

            double[] sum = CountSums(x, 2 * (n - 1), n);
            //Коэффициенты в строках - сумма всех (x в степени i)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = sum[i + j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, n] += Math.Pow(x[j], i) * y[j];
                }
            }

            return a;
        }

        /// <summary>
        /// обмен двух элементов
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swap(ref double a, ref double b)
        {
            double w = a;
            a = b;
            b = w;
        }

        /// <summary>
        /// Обмен двух строк
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        static void SwapLines(double[,] a, int n, int i1, int i2)
        {
            for (int j = 0; j <= n; j++)
            {
                Swap(ref a[i1, j], ref a[i2, j]);
            }
        }

        /// <summary>
        /// Эвристический выбор опорного элемента
        /// Берем максимальный элемент столбца
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        static int Pivote(double[,] a, int n, int j)
        {
            int maximal = j;
            for (int i = j + 1; i < n; i++)
            {
                if (Math.Abs(a[i, j]) > Math.Abs(a[maximal, j]))
                    maximal = i;
            }
            return maximal;
        }

        /// <summary>
        /// Преобразуем строку в порядке работы алгоритма Гаусса, деля каждый эл-т на коэффициент
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="i"></param>
        static void NormalizeLine(double[,] a, int n, int i)
        {
            double divisor = a[i, i];
            for (int j = 0; j <= n; j++)
            {
                a[i, j] /= divisor;
            }
        }

        /// <summary>
        /// Проводит действия с i1-й строкой, зануляя элемент a[i1,j1]
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="j1"></param>
        /// <param name="i1"></param>
        static void NillRowOnLine(double[,] a, int n, int j1, int i1)
        {
            double coeff = a[i1, j1];
            for (int j = j1; j <= n; j++)
            {
                a[i1, j] -= a[j1, j] * coeff;
            }
        }


        /// <summary>
        /// Реализация алгоритма Гаусса для матрицы
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static double[] MakeGauss(double[,] a, int n)
        {
            for (int j = 0; j < n; j++)
            {
                SwapLines(a, n, j, Pivote(a, n, j));
                NormalizeLine(a, n, j);
                for (int i = 0; i < n; i++)
                {
                    if (i == j)
                        continue;

                    NillRowOnLine(a, n, j, i);
                }
            }

            double[] ans = new double[n];
            for (int i = 0; i < n; i++)
            {
                ans[i] = a[i, n];
            }
            return ans;
        }

        /// <summary>
        ///Аппроксимация функции
        ///Возвращает массив размера n, состоящий из коэффициентов при х в полиноме
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double[] ApproximateFunction(double[] x, double[] y, int n)
        {
            double[,] a = new double[n, n + 1];
            a = ReadMatrix(x, y, n);
            double[] ans = new double[n];
            ans = MakeGauss(a, n);
            return ans;
        }
    }
}
