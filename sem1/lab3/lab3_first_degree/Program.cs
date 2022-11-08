using System;

namespace lab3_first
{
    class Program
    {
        static void Main(string[] args)
        {
            // пример 13
            Console.WriteLine("1.13: ");
            int[] source = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] uneven = new int[5];
            int[] even = new int[5];
            int evenIndex = 0;
            int unevenIndex = 0;

            for (int i = 0; i < source.Length; i++)
            {
                if (i % 2 == 0) {
                    even[evenIndex] = source[i];
                    evenIndex++;
                }
                else {
                    uneven[unevenIndex] = source[i];
                    unevenIndex++;
                }
            }
            for (int k = 0; k < even.Length; k++)
                Console.Write("{0}, ", even[k]);
                Console.WriteLine();
            for (int k = 0; k < uneven.Length; k++)
                Console.Write("{0}, ", uneven[k]);
            

            // пример 14
            Console.WriteLine("\n1.14 введите целые числа (в том числе и отрицательные): ");
            int[] elems = new int[11];
            string s;
            for (int i = 0; i < 11; i++) {
                s = Console.ReadLine();
                elems[i] = int.Parse(s);
            }
            int sum = 0;
            foreach (int item in elems)
            {
                if (item >= 0) {
                    sum += item*item;
                }
                else {
                    break;
                }
            }
            Console.WriteLine(sum);

            // пример 15
            Console.WriteLine("\n1.15 введите неотрицательные числа: ");
            double[] x = new double[10]; 
            double[] y = new double[10];

            for (int i = 0; i < 10; i++) {
                s = Console.ReadLine();
                x[i] = double.Parse(s);
                y[i] = Math.Log(x[i]);
            }
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("{0} |  {1}", x[i], y[i]);
            }
        }
    }
}
