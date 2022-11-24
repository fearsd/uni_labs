using System;


namespace lab5_second
{
    class Program
    {
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
        static void PrintArray(int[] arr, int n) {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0:d} ", arr[i]);
            }
            Console.WriteLine();
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
        static int[] MaxElemInMatrix(int[,] mat, int ii, int jj) {
            int max = 0, i_elem = 0, j_elem = 0;
            for (int i = 0; i < ii; i++) {
                for (int j = 0; j < jj; j++) {
                    if(max < mat[i, j]) {
                        max = mat[i, j];
                        i_elem = i;
                        j_elem = j;
                    }
                }
            }
            return new int[]{i_elem, j_elem};
        }
        static int[] FullArray(int[] arr, int n, bool isRandom = true) {
            Random r = new Random();
            for (int i = 0; i < n; i++) {
                if(isRandom) arr[i] = r.Next(50);
                else {
                    Console.Write("Запишите элемент: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }
        static int MaxElemInArray(int[] arr, int n) {
            int max = 0, i_elem = 0;
            
            for (int i = 0; i < n; i++) {
                if(max < arr[i]) {
                    max = arr[i];
                    i_elem = i;
                }
            }
            return i_elem;
        }
        static double ArithmeticMean(int[] arr, int i_max, int n) {
            int elemNum = (n - 1) - i_max;
            int sum = 0;
            for (int i = i_max + 1; i < n; i++) {
                sum += arr[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(elemNum);
            return sum / elemNum;
        }

        static int FindMaxElemOnMainDiag(int[,] mat, int n) {
            int i_max = 0, max = mat[i_max, i_max];
            for(int i = 0; i < n; i++) {
                if (max < mat[i, i]) {
                    i_max = i;
                    max = mat[i, i];
                }
            }
            return i_max;
        }

        static int[,] DeleteRowInMatrix(int[,] mat, int row, int n) {
            for(int i = row; i < n - 1; i++) {
                for(int j = 0; j < n; j++) {
                    mat[i, j] = mat[i+1, j];
                }
            }
            return mat;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("задача 1: ");
            int ai = 5, aj = 6, bi = 3, bj = 5;
            int p;
            int[,] A = new int[5, 6];
            int[,] B = new int[3, 5];

            A = FullMatrix(A, ai, aj);
            B = FullMatrix(B, bi, bj);

            Console.WriteLine("Матрица А");
            PrintMatrix(A, ai, aj);
            Console.WriteLine("Матрица B");
            PrintMatrix(B, bi, bj);
            Console.WriteLine();

            int[] A_max = MaxElemInMatrix(A, ai, aj);
            int[] B_max = MaxElemInMatrix(B, bi, bj);

            p = A[A_max[0], A_max[1]];
            A[A_max[0], A_max[1]] = B[B_max[0], B_max[1]];
            B[B_max[0], B_max[1]] = p;

            Console.WriteLine("Матрица А");
            PrintMatrix(A, ai, aj);
            Console.WriteLine("Матрица B");
            PrintMatrix(B, bi, bj);
            Console.WriteLine();



            Console.WriteLine("задача 2: ");
            int[] A2 = new int[9];
            int[] B2 = new int[7];
            A2 = FullArray(A2, 9);
            B2 = FullArray(B2, 7);

            Console.WriteLine("Массив A");
            PrintArray(A2, 9);
            Console.WriteLine("Массив B");
            PrintArray(B2, 7);
            Console.WriteLine();

            int A2_max = MaxElemInArray(A2, 9);
            int B2_max = MaxElemInArray(B2, 7);

            int arith_m;
            if (9 - A2_max > 7 - B2_max) {
                arith_m = Convert.ToInt32(ArithmeticMean(A2, A2_max, 9));
                A2[A2_max] = arith_m;
            }
            else {
                arith_m = Convert.ToInt32(ArithmeticMean(B2, B2_max, 7));
                B2[B2_max] = arith_m;
            }

            Console.WriteLine("Массив A");
            PrintArray(A2, 9);
            Console.WriteLine("Массив B");
            PrintArray(B2, 7);
            Console.WriteLine();


            Console.WriteLine("задача 3: ");
            int nb = 5, nc = 6;
            int[,] B3 = new int[nb, nb], C3 = new int[nc, nc];

            B3 = FullMatrix(B3, nb, nb);
            C3 = FullMatrix(C3, nc, nc);

            Console.WriteLine("Матрица B");
            PrintMatrix(B3, nb, nb);
            Console.WriteLine("Матрица C");
            PrintMatrix(C3, nc, nc);
            Console.WriteLine();

            int b3_max = FindMaxElemOnMainDiag(B3, nb);
            int c3_max = FindMaxElemOnMainDiag(C3, nc);

            B3 = DeleteRowInMatrix(B3, b3_max, nb);
            C3 = DeleteRowInMatrix(C3, c3_max, nc);

            Console.WriteLine("Матрица B");
            PrintMatrix(B3, nb, nb, 1);
            Console.WriteLine("Матрица C");
            PrintMatrix(C3, nc, nc, 1);
            Console.WriteLine();
            
        }
    }
}