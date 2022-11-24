using System;


namespace lab5_third
{
    class Program
    {
        delegate int[] TriangleElements(int[,] mat, int n);

        delegate double fx(double x);

        static void PrintMatrix(int[,] mat, int ii, int jj, int rowStep = 0) {
            for (int i = 0; i < ii - rowStep; i++)
            {
                for (int j = 0; j < jj; j++)
                {
                    Console.Write("{0:d} ", mat[i, j]);
                }
                Console.WriteLine();
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

        static int SumOfSquares(TriangleElements triangleElements, int[,] mat) {
            int sum = 0;
            int n = mat.GetLength(0);
            foreach (int num in triangleElements(mat, n))
            {
                sum += num * num;
            }
            return sum;
        }

        static int AlgebraicProgressionSum(int a, int d, int n) {
            return (2 * a + d * (n - 1)) / 2 * n;
        }

        static int[] DownTriangleElems(int[,] mat, int n) {
            int[] elems = new int[AlgebraicProgressionSum(1, 1, n)+1];
            int m = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < i + 1; j++) {
                    elems[m] = mat[i, j];
                    m++;
                }
            }

            return elems;
        }

        static int[] TransponMatrixAndTriangle(int[,] mat, int n) {
            int p;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i+1; j < n; j++) 
                {
                    p = mat[i, j];
                    mat[i, j] = mat[j, i];
                    mat[j, i] = p;
                }
            }
            return DownTriangleElems(mat, n);
        }

        static double func1(double x) {
            return x * x - Math.Sin(x);
        }

        static double func2(double x) {
            return Math.Exp(x) - 1;
        }

        static bool IfNumsHaveSimSigns(double num1, double num2) {
            return (num1 <= 0) == (num2 <= 0);
        }

        static int intervalNum(fx f, double x0, double xn, double step) {
            int num = 1;
            while (x0 <= xn) {
                x0 += step;
                if(!IfNumsHaveSimSigns(f(x0-step), f(x0))) {
                    num+=1;
                }
            }
            return num;
        }

        static void Main(string[] args)
        {
            int na;
            Console.WriteLine("задача 4: ");

            Console.Write("введите размерность A матрицы: ");
            na = int.Parse(Console.ReadLine());

            int[,] A = new int[na, na];
            
            A = FullMatrix(A, na, na);

            Console.WriteLine("Матрица А");
            PrintMatrix(A, na, na);
            
            Console.Write("Сумма квадратов нижнего треугольника: ");
            Console.WriteLine(SumOfSquares(DownTriangleElems, A));
            Console.Write("Сумма квадратов верхнего треугольника: ");
            Console.WriteLine(SumOfSquares(TransponMatrixAndTriangle, A));
            

            Console.WriteLine("задача 5: ");
            Console.WriteLine(intervalNum(func1, 0, 2, 0.1));
            Console.WriteLine(intervalNum(func2, -1, 1, 0.2));
        }
    }
}
