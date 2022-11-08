using System;

namespace lb3_second{
    class Program {
        static void Main(string[] args) {
            // // 8 пример
            // Console.WriteLine("2.8 Введите кол-во элементов");
            // int elemNum = int.Parse(Console.ReadLine());

            // double[] elems = new double[elemNum];
            // Console.WriteLine("Введите элементы массива: ");
            // for (int i = 0; i < elemNum; i++) {
            //     string s = Console.ReadLine();
            //     elems[i] = int.Parse(s);
            // }

            // double elem_max = elems[0];
            // int imax = 0;
            // for (int i = 0; i < elemNum; i++)
            // {
            //     if (elems[i] > elem_max)
            //     {
            //         elem_max = elems[i];
            //         imax = i;
            //     }
            // }

            // double elem_min = elems[imax+1];
            // int imin = 0;
            // for (int i = imax + 1; i < elemNum; i++)
            // {
            //     if (elems[i] < elem_min)
            //     {
            //         elem_min = elems[i];
            //         imin = i;
            //     }
            // }
            // elems[imax] = elem_min;
            // elems[imin] = elem_max;

            // for (int k = 0; k < elemNum; k++)
            //     Console.Write("{0}, ", elems[k]);

            // // 9 пример
            // Console.WriteLine("\n2.9  Введите кол-во элементов");
            // int elemNum2 = int.Parse(Console.ReadLine());

            // double[] elems2 = new double[elemNum2];
            // Console.WriteLine("Введите элементы массива: ");
            // for (int i = 0; i < elemNum2; i++) {
            //     string s = Console.ReadLine();
            //     elems2[i] = int.Parse(s);
            // }

            // double elem_max2 = elems2[0];
            // int imax2 = 0;
            // for (int i = 0; i < elemNum2; i++)
            // {
            //     if (elems2[i] > elem_max2)
            //     {
            //         elem_max2 = elems2[i];
            //         imax2 = i;
            //     }
            // }

            // double elem_min2 = elems2[0];
            // int imin2 = 0;
            // for (int i = 0; i < elemNum2; i++)
            // {
            //     if (elems2[i] < elem_min2)
            //     {
            //         elem_min2 = elems2[i];
            //         imin2 = i;
            //     }
            // }

            // double sum = 0;
            // if (Math.Abs(imax2-imin2) == 1) {
            //     Console.WriteLine("NOTHING");
            // }
            // else {
            //     int ileft = Math.Min(imin2, imax2) + 1;
            //     int iright = Math.Max(imin2, imax2);
            //     for (int i = ileft; i < iright; i++) {
            //         sum += elems2[i];
            //     }
            //     Console.WriteLine(sum/(iright-ileft));

            // }

            // 10 пример
            Console.WriteLine("\n2.10  Введите кол-во элементов");
            int elemNum3 = int.Parse(Console.ReadLine());

            double[] elems3 = new double[elemNum3];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < elemNum3; i++) {
                string s = Console.ReadLine();
                elems3[i] = int.Parse(s);
            }

            double elem_max3 = elems3[0];
            for (int i = 0; i < elemNum3; i++)
            {
                if (elems3[i] > elem_max3)
                {
                    elem_max3 = elems3[i];
                }
            }

            int imin3 = 0;
            double elem_min3 = elem_max3;
            for (int i = 0; i < elemNum3; i++) {
                if ((elems3[i] < elem_min3) && (elems3[i] >= 0)) {
                    elem_min3 = elems3[i];
                    imin3 = i;
                }
            }

            for (int i = imin3; i < elemNum3 - 1; i++)
                elems3[i] = elems3[i + 1];
            for (int i = 0; i < elemNum3 - 1; i++)
                Console.Write("{0} ", elems3[i]);
            Console.WriteLine();


            double f, x, y, z;
            Random r = new Random();
            x = r.Next(50);
            y = r.Next(50);
            z = r.Next(50);
            
            f = (Math.Pow(y+Math.Pow(x-1, 1/3), 1/4))/(Math.Abs(x-y)*(Math.Pow(Math.Sin(z), 2) + Math.Tan(z)));

        }
    }
}
