using System;

namespace lb1
{
    class Program
    {
        static void Main(string[] args)
        {
            // // 10. Возвести число 3 в 7-ю степень, не используя операцию возведения в степень.
            // int num = 3, answer = 3;
            // for (int i = 1; i < 7; i++)
            // {
            //     answer *= num;
            // }
            // Console.WriteLine("Ответ 10 примера: ");
            // Console.WriteLine(answer);

            /* 11. Напечатать заданную последовательность чисел:
            а) 1 2 3 4 5 6,
            б) 5 5 5 5 5 5.
            */
            // Console.WriteLine("\nОтвет 11(a) примера: ");
            // for (int i = 1; i < 7; i++)
            // {
            //     Console.Write(i);
            // }

            // Console.WriteLine("\nОтвет 11(б) примера: ");
            // for (int i = 1; i < 7; i++)
            // {
            //     Console.Write(5);
            // }
            // Console.WriteLine();



            // 12. Вычислить при заданном x сумму s = 1 + 1/x + 1/x2 + ... + 1/x10.
            Console.WriteLine("\n Начало 12 примера, введите число(ноль невалиден): ");
            double a, ans = 0, l = 0;
            int j = 0;
            do
            {
                a = double.Parse(Console.ReadLine());
            } while (a == 0);

            while (j <= 10)
            { 
                l = 1 / Math.Pow(a, j);
                ans += l;
                Console.WriteLine("Прибавили {0}, получилось {1}", l, ans);
                j += 1;
            }
            Console.WriteLine(ans);
        }
    }
}
