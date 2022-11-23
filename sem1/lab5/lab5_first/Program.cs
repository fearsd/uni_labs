using System;


namespace lab5_first
{
    class Program
    {
        static int factorial(int num) {
            int n = 1;
            for (int i = 0; i <= num; i++ ) {
                if (i == 0) {
                    n *= 1;
                }
                else {
                    n *= i;
                }
            }
            return n;
        }
        static int C_function(int n, int k) {
            int C = factorial(n)/(factorial(k)*factorial(n-k));
            return C;
        }

        static double p(int a, int b, int c) {
            return (a+b+c)/2;
        }

        static double S(int v, int t, double a) {
            return v*t + (a*t*t)/2;         
        }
        static void Main(string[] args)
        {
            Console.WriteLine("задача 1:");
            int k = 5;
            int[] n = {8, 10, 11};
            foreach (int i in n)
            {   
                Console.WriteLine(C_function(i, k));
            }
            Console.WriteLine();


            Console.WriteLine("задача 2:");
            double _p = p(3, 4, 5); 
            double _S = Math.Sqrt(_p*(_p-3)*(_p-4)*(_p-5));
            Console.WriteLine(_S);
            Console.WriteLine();

            Console.WriteLine("задача 3:");
            Console.WriteLine(S(10, 1, 1));
            Console.WriteLine(S(10, 4, 1));
            Console.WriteLine(S(9, 1, 1.6));
            Console.WriteLine(S(9, 4, 1.6));

        }
    }    
}
