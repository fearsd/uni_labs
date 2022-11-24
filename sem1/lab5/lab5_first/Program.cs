using System;


namespace lab5_first
{
    class Program
    {
        static int factorial(int num) {
            int n = 1;
            for (int i = 1; i <= num; i++) {
                n *= i;
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

        static double Geron(double p, int a, int b, int c) {
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        static double S(int v, int t, double a) {
            return v*t + (a*t*t)/2;         
        }
        static double TimeToCome(int v1, int v2, double a1, double a2) {
            return 2*((v2 - v1) / (a1 - a2));
        }
        static void WhoFaster(double S1, double S2) {
            if(S1 > S2) {
                Console.WriteLine("Велосипедист 1 проедет больше");
            }
            else {
                Console.WriteLine("Велосипедист 2 проедет больше");
            }
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
            int a = 3, b = 4, c = 5;
            double _p = p(a, b, c);
            double _S = Geron(_p, a, b, c);
            Console.WriteLine(_S);
            Console.WriteLine();

            Console.WriteLine("задача 3a:");
            int v1 = 10, v2 = 9, t1 = 1, t2 = 4;
            double a1 = 1, a2 = 1.6;
            Console.WriteLine("{0} {1}", S(v1, t1, a1), S(v2, t1, a2));
            Console.WriteLine("{0} {1}", S(v1, t2, a1), S(v2, t2, a2));
            WhoFaster(S(v1, t1, a1), S(v2, t1, a2));
            WhoFaster(S(v1, t2, a1), S(v2, t2, a2));

            Console.WriteLine("задача 3a:");
            Console.WriteLine(TimeToCome(v1, v2, a1, a2));

        }
    }    
}
