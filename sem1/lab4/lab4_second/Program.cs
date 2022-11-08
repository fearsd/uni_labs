using System;
 
namespace lab4_first
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 пример
            Console.WriteLine("2.1");
            Random r = new Random();
            int ii = 5;
            int jj = 7;
            int[,] A = new int[ii, jj];
            int jmax = 0, max = 0;

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

            for(int i = 0; i < ii; i++)
            {
                for(int j = 0; j < jj; j++)
                {
                    if (A[i, j] > max) {
                        max = A[i,j];
                        jmax = j;
                    }
                }
                if (jmax == 0) {
                    A[i, jmax + 1] *= 2;
                }
                else if (jmax == jj-1) {
                    A[i, jmax - 1] *= 2;
                }
                else {
                    A[i, jmax - 1] *= 2;
                    A[i, jmax + 1] *= 2;
                }
                max = 0;
            }

            Console.WriteLine("\nРезультат: ");
            for (int i = 0; i < ii; i++)
            {
                for (int j = 0; j < jj; j++)
                {
                    Console.Write("{0:d} ", A[i, j]);
                }
                Console.WriteLine();
            }




            // 2 пример
            Console.WriteLine("\n2.2");
            int ii2 = 7;
            int jj2 = 5;
            int[,] A2 = new int[ii2, jj2];
            int negative = 0, positive = 0, max2=0, imax2=0;

            // заполнение матрицы
            for(int i = 0; i < ii2; i++)
            {
                for(int j = 0; j < jj2; j++)
                {
                    Console.Write("Запишите элемент {0} строки {1} столбца ", i+1, j+1);
                    A2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < ii2; i++)
            {
                for (int j = 0; j < jj2; j++)
                {
                    Console.Write("{0:d} ", A2[i, j]);
                }
                Console.WriteLine();
            }

            for (int j = 0; j < jj2; j++) {
                for (int i = 0; i < ii2; i++) {
                    if (A2[i, j] < 0) negative++;
                    else positive++;
                    if (max2 < A2[i, j]) {
                        max2 = A2[i, j];
                        imax2 = i;
                    }
                }
                if (positive > negative) A2[imax2, j] = 0;
                else A2[imax2, j] = imax2 + 1;
                max2 = 0;
                imax2 = 0;
                positive = 0;
                negative = 0;
            }
            Console.WriteLine("\nРезультат: ");
            for (int i = 0; i < ii2; i++)
            {
                for (int j = 0; j < jj2; j++)
                {
                    Console.Write("{0:d} ", A2[i, j]);
                }
                Console.WriteLine();
            }




            // 3 пример
            Console.WriteLine("\n2.3");
            int ii3 = 10;
            int jj3 = 5;
            int[,] A3 = new int[ii3, jj3];
            int max3 = 0, imax3 = 0, sum = 0;
            // заполнение матрицы рандомными числами
            for(int i = 0; i < ii3; i++)
            {
                for(int j = 0; j < jj3; j++)
                {
                    A3[i, j] = r.Next(20);
                }
            }
            // вывод матрицы
            for (int i = 0; i < ii3; i++)
            {
                for (int j = 0; j < jj3; j++)
                {
                    Console.Write("{0:d} ", A3[i, j]);
                }
                Console.WriteLine();
            }

            for (int j = 0; j < jj3; j++) {
                for (int i = 0; i < ii3; i++) {
                    if (max3 < A3[i, j]) {
                        max3 = A3[i, j];
                        imax3 = i;
                        sum = 0;
                    }
                    else if (i != 0) {
                        sum += A3[i, j];
                    }
                }
                if (imax3 < ii3 / 2) {
                    A3[0, j] = sum;
                }
                imax3 = 0;
                sum = 0;
                max3 = 0;
            }
            Console.WriteLine("\nРезультат: ");
            for (int i = 0; i < ii3; i++)
            {
                for (int j = 0; j < jj3; j++)
                {
                    Console.Write("{0:d} ", A3[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}