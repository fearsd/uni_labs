using System;

namespace lb1_second_level
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Вкладчик положил в банк 10 000 рублей под 8 % в месяц. Определить, через какое время сумма удвоится.
            // int depositRate = 8, month = 0;
            // double sum = 10000;
            // while (sum <= 10000*2)
            // {
            //     sum += sum / 100 * depositRate;
            //     month += 1;
            // }
            // Console.WriteLine("Ответ 8 примера\nЧерез сколько месяцев: {0}\n", month);


            /* 9. Определить, сколько раз нужно разрезать пополам металлическую нить длиной L = 0,1 м,
                  чтобы ее длина уменьшилась до атома (размер атома DА считать равным 10-10 м). 
            */
            // double L = 0.1, Atom = 0.0000000001;
            // int CutNum = 0;
            // while (L > Atom)
            // {
            //     L /= 2;
            //     CutNum += 1;
            // }
            // Console.WriteLine("Ответ 9 примера\nЧерез сколько раз: {0}\n", CutNum);

            /* 10. В задаче 15 уровня I вычислить член последовательности,
                который отличается от предыдущего члена не более чем на 0,001.

                (Вычислить 5-й член последовательности, образованной дробями 1/1, 2/1, 3/2, …,
                т.е. числитель (знаменатель) следующего члена последовательности получается сложением 
                числителей (знаменателей) двух предыдущих членов.)
            */
            List<double> numerators = new List<double>() {1, 2, 3};
            List<double> denominators = new List<double>() {1, 1, 2};

            while ( Math.Abs((numerators[^1] / denominators[^1]) - (numerators[^2] / denominators[^2])) >= 0.001)
            {
                numerators.Add(numerators[^1]+numerators[^2]);
                denominators.Add(denominators[^1]+denominators[^2]);
            }
            Console.WriteLine("Ответ 10 примера\nЧлен последовательности: {0}\n", numerators.Count());

        }
    }
}