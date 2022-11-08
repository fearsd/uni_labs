using System;
using System.Linq;
 
namespace lab4_first
{
    class Program
    {
        static void Main(string[] args)
        {
            // задача 28
            Console.WriteLine("1.28");
            Random r = new Random();
            int ii = 7;
            int jj = 5;
            int[,] A = new int[ii, jj];
            int[] sum = new int[ii]; // для хранения сумм элементов строк
            int m, imax, _max;

            // заполнение матрицы рандомными числами
            for(int i = 0; i < ii; i++)
            {
                for(int j = 0; j < jj; j++)
                {
                    A[i, j] = r.Next(20);
                }
            }

            // вывод матрицы
            for (int i = 0; i < ii; i++)
            {
                for (int j = 0; j < jj; j++)
                {
                    Console.Write("{0:d} ", A[i, j]);
                }
                Console.WriteLine();
            }

            // вычисление сумм строк в матрице
            for (int i = 0; i < ii; i++)
            {
                m = 0;
                for (int j = 0; j < jj; j++)
                {
                    m += A[i, j];
                }
                sum[i] = m;
            }

            _max = sum.Max();
            imax = Array.IndexOf(sum, _max);

            for(int i = imax; i < ii - 1; i++)
            {
                for(int j = 0; j < jj; j++)
                {
                    A[i, j] = A[i + 1, j];
                }
            }


            // вывод результата
            Console.WriteLine("\nРезультат: ");
            for (int i = 0; i < ii - 1; i++)
            {
                for (int j = 0; j < jj; j++)
                {
                    Console.Write("{0:d} ", A[i, j]);
                }
                Console.WriteLine();
            }
 
 
 
 
 
            // задача 29
            Console.WriteLine("\n1.29");
            int ii2 = 5;
            int jj2 = 7;
            int[,] F = new int[ii2, jj2];
            int[] elems = new int[jj2];
            int _min, imin;

            // заполнение матрицы рандомными числами
            for (int i = 0; i < ii2; i++)
            {
                for (int j = 0; j < jj2; j++)
                {
                    if (i == 1 && j == jj2 - 1) F[i, j] = 30; // для того, чтобы в последнем столбце не было минимального элемента
                    else F[i, j] = r.Next(20);
                }
            }

            // вывод матрицы
            for (int i = 0; i < ii2; i++)
            {
                for (int j = 0; j < jj2; j++)
                {
                    Console.Write("{0:d} ", F[i, j]);
                }
                Console.WriteLine();
            }

            for (int j = 0; j < jj2; j++)
            {
                elems[j] = Math.Abs(F[1, j]);
            }
            Console.WriteLine();

            _min = elems.Min();
            imin = Array.IndexOf(elems, _min);

            for (int j = imin + 1; j < jj2 - 1; j++)
            {
                for (int i = 0; i < ii2; i++)
                {
                    F[i, j] = F[i, j + 1];
                }
            }

            // вывод результата
            Console.WriteLine("\nРезультат: ");
            for (int i = 0; i < ii2; i++)
            {
                for (int j = 0; j < jj2 - 1; j++)
                {
                    Console.Write("{0:d} ", F[i, j]);
                }
                Console.WriteLine();
            }




            // 30 пример
            int n = 5;
            int[,] B = new int[n, n];
            int imax3 = 0, max = 0, imin3 = 0, p;

            Console.WriteLine("\n1.30");

            // заполнение матрицы
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("Запишите элемент {0} строки {1} столбца ", i+1, j+1);
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0:d} ", B[i, j]);
                }
                Console.WriteLine();
            }

            // поиск строки с максимальным элементом по глав диагонали
            for(int i = 0; i < n; i++) {
                if (max < B[i, i]) {
                    max = B[i, i];
                    imax3 = i;
                }
            }

            // поиск строки с первым отр элементом по 3 столбцу
            for(int i = 0; i < n; i++) {
                if( B[i, 2] < 0) {
                    imin3 = i;
                    break;
                }
            }

            // замена местами строк
            for(int i = 0; i < n; i++) {
                p = B[imax3, i];
                B[imax3, i] = B[imin3, i];
                B[imin3, i] = p;
            }
            // вывод результата
            Console.WriteLine("\nРезультат: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0:d} ", B[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
