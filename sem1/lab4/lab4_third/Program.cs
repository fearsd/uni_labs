using System;

namespace lab4_first
{
    public class ExtremumElement
    {
        public int RowIndex { get; set; }
        public int Value { get; set; }
    }
    
    class Program
    {
        static int[,] DownTriangle(int[,] mat, int n) {
            for (int j = 0; j < n - 1; j++)
            {
                for (int k = j+1; k < n; k++)
                {
                    for (int m = j; m < n; m++)
                    {
                        mat[k, m] -= mat[j, m]*mat[k, j]/mat[j, j];
                    }
                }
            }
            return mat;
        }

        static int[] DownTriangleAsArray(int[] arr, int n) {
            for (int j = 0; j < n - 1; j++)
            {
                for (int k = j+1; k < n; k++)
                {
                    for (int m = j; m < n; m++)
                    {
                        arr[k*n + m] -= arr[j*n + m]*arr[k*n + j]/arr[j*n+j];
                    }
                }
            }
            return arr;
        }

        static void PrintMatrix(int[,] mat, int ii, int jj) {
            for (int i = 0; i < ii; i++)
            {
                for (int j = 0; j < jj; j++)
                {
                    Console.Write("{0:d} ", mat[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void PrintArrayAsMatrix(int[] arr, int ii, int jj) {
            for (int i = 0; i < ii*jj; i++)
            {
                Console.Write("{0} ", arr[i]);
                if ((i + 1) % jj == 0) Console.WriteLine();
            }
        }

        static int[,] FullMatrix(int[,] mat, int ii, int jj, bool isRandom=true) {
            Random r = new Random();
            for (int i = 0; i < ii; i++) {
                for (int j = 0; j < jj; j++) {
                    if(isRandom) mat[i, j] = r.Next(50);
                    else {
                        Console.Write("Запишите элемент {0} строки {1} столбца ", i+1, j+1);
                        mat[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            return mat;
        }

        static int[] FullArrayAsMatrix(int[] arr, int ii, int jj, bool isRandom=true) {
            Random r = new Random();
            for (int i = 0; i < ii; i++) {
                for (int j = 0; j < jj; j++) {
                    if(isRandom) arr[i*jj + j] = r.Next(50);
                    else {
                        Console.Write("Запишите элемент {0} строки {1} столбца ", i+1, j+1);
                        arr[i*jj + j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            return arr;
        }

        static int[] GetRowByIndex(int[,] mat, int RowIndex, int ColumnNum) {
            int[] rows = new int[ColumnNum];
            for (int i = 0; i < ColumnNum; i++) {
                rows[i] = mat[RowIndex, i];
            }
            return rows;
        }
        static int[] GetRowByIndexInArray(int[] arr, int RowIndex, int ColumnNum) {
            int[] rows = new int[ColumnNum];
            for (int i = 0; i < ColumnNum; i++) {
                rows[i] = arr[ColumnNum*RowIndex+i];
            }
            return rows;
        }

        static void Main(string[] args)
        {
            // 14 пример
            Console.WriteLine("3.14. Введите размер n*n матрицы");
            int n, p;
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            int[] a_arr = new int[n*n];

            a = FullMatrix(a, n, n);
            a_arr = FullArrayAsMatrix(a_arr, n, n);

            Console.WriteLine("Как матрица: ");
            PrintMatrix(a, n, n);
            Console.WriteLine("Как массив: ");
            PrintArrayAsMatrix(a_arr, n, n);
            Console.WriteLine();



            // обнуляем нижний треугольник
            a = DownTriangle(a, n);
            a_arr = DownTriangleAsArray(a_arr, n);

            // транспонируем матрицу
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i+1; j < n; j++) 
                {
                    p = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = p;
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i+1; j < n; j++) 
                {
                    p = a_arr[i*n+j];
                    a_arr[i*n+j] = a_arr[j*n+i];
                    a_arr[j*n+i] = p;
                }
            }

            // обнуляем нижний треугольник
            a = DownTriangle(a, n);
            a_arr = DownTriangleAsArray(a_arr, n);

            Console.WriteLine("Ответ: ");
            Console.WriteLine("Как матрица: ");
            PrintMatrix(a, n, n);
            Console.WriteLine("Как массив: ");
            PrintArrayAsMatrix(a_arr, n, n);




            // 1 пример
            Console.WriteLine("\n3.1");
            int ii = 7, jj = 5;
            int[,] A = new int[ii,jj];
            int[] A_arr = new int[ii*jj];
            int rowIndex = 0;
            int rowIndex_arr = 0;
            List<ExtremumElement> minimums = new List<ExtremumElement>();
            List<ExtremumElement> minimums_arr = new List<ExtremumElement>();
            
            // заполнение рандомными значениями
            A = FullMatrix(A, ii, jj);
            A_arr = FullArrayAsMatrix(A_arr, ii, jj);

            Console.WriteLine("Как матрица: ");
            PrintMatrix(A, ii, jj);
            Console.WriteLine("Как массив: ");
            PrintArrayAsMatrix(A_arr, ii, jj);
            Console.WriteLine();

            // получаем список {rowIndex; minValue} для матрицы
            for (int i = 0; i < ii; i++) {
                int[] rows = GetRowByIndex(A, i, jj);
                int minElement = rows.Min();
                minimums.Add(new ExtremumElement{RowIndex = i, Value = minElement});
            }
            // сортируем элементы списка по minValue по убыванию
            List<ExtremumElement> sortedMinimums = minimums.OrderBy(e => e.Value).ToList();
            sortedMinimums.Reverse();
            
            // получаем список {rowIndex; minValue} для массива
            for (int i = 0; i < ii; i++) {
                int[] rows = GetRowByIndexInArray(A_arr, i, jj);
                int minElement = rows.Min();
                minimums_arr.Add(new ExtremumElement{RowIndex = i, Value = minElement});
            }
            // сортируем элементы списка по minValue по убыванию
            List<ExtremumElement> sortedMinimums_arr = minimums_arr.OrderBy(e => e.Value).ToList();
            sortedMinimums_arr.Reverse();


            // создаем новую матрицу
            int[,] sortedMatrix = new int[ii, jj];
            foreach (ExtremumElement elem in sortedMinimums) {
                for (int i = 0; i < jj; i++)
                    sortedMatrix[rowIndex, i] = A[elem.RowIndex, i];
                rowIndex++;
            }
            
            // создаем новую матрицу
            int[] sortedArrayAsMatrix = new int[ii*jj];
            foreach (ExtremumElement elem in sortedMinimums_arr) {
                for (int i = 0; i < jj; i++)
                    sortedArrayAsMatrix[rowIndex_arr*jj + i] = A_arr[elem.RowIndex*jj + i];
                rowIndex_arr++;
            }

            Console.WriteLine("Ответ: ");
            Console.WriteLine("Как матрица: ");
            PrintMatrix(sortedMatrix, ii, jj);
            Console.WriteLine("Как массив: ");
            PrintArrayAsMatrix(sortedArrayAsMatrix, ii, jj);
            Console.WriteLine();

            


            // 2 пример
            Console.WriteLine("\n3.2. Введите размер n*n матрицы");
            int n2;
            n2 = int.Parse(Console.ReadLine());
            int[,] mat2 = new int[n2, n2];
            int[] mat2_arr = new int[n2*n2];

            // заполнение матриц рандомными элементами
            mat2 = FullMatrix(mat2, n2, n2);
            mat2_arr = FullArrayAsMatrix(mat2_arr, n2, n2);

            Console.WriteLine("Как матрица: ");
            PrintMatrix(mat2, n2, n2);
            Console.WriteLine("Как массив: ");
            PrintArrayAsMatrix(mat2_arr, n2, n2);
            Console.WriteLine();


            // обнуляем периметр для матрицы
            for (int i = 0; i < n2; i++) {
                mat2[i, 0] = 0;
                mat2[0, i] = 0;
                mat2[n2-1, i] = 0;
                mat2[i, n2-1] = 0;
            }

            // обнуляем периметр для массива
            for (int i = 0; i < n2; i++) {
                mat2_arr[i*n2 + 0] = 0;
                mat2_arr[0*n2 + i] = 0;
                mat2_arr[(n2 - 1)*n2 +i] = 0;
                mat2_arr[i*n2+(n2-1)] = 0;
            }

            Console.WriteLine("Ответ: ");
            Console.WriteLine("Как матрица: ");
            PrintMatrix(mat2, n2, n2);
            Console.WriteLine("Как массив: ");
            PrintArrayAsMatrix(mat2_arr, n2, n2);
        }
    }
}