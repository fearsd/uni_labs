using System;
using System.Linq;

namespace lab6_first {

    struct Answer {
        public string answer;
        public int num;
        public double procent = 0;
        public Answer(string answer, int num) {
            this.answer = answer;
            this.num = num;
        }
    }


    struct Sportsman {
        public string name;
        public int res1;
        public int res2;
        public int best;
        public Sportsman(string name, int res1, int res2) {
            this.name = name;
            this.res1 = res1;
            this.res2 = res2;
            if (this.res1 > this.res2) {
                this.best = this.res1;
            }
            else {
                this.best = this.res2;
            }
        }
    }

    struct Student {
        public int mark;
        public int missedLessons;
        public string name;

        public Student(int mark, int missedLessons, string name) {
            this.mark = mark;
            this.missedLessons = missedLessons;
            this.name = name;
        }
    }

    class Program {
        static int randomNum(int numEnd) {
            Random random = new Random();
            return random.Next(numEnd);
        }

        static string randomChoice() {
            string[] choices = {"Путин", "Обама", "Байден", "Месси", "Роналду", "Собянин", "Киркоров", "Басков", "Джек Воробей", "Тим Кук"};
            return choices[randomNum(choices.Count())];
        } 

        static void fullAnswers(Answer[] answers, int n) {
            for (int i = 0; i < n; i++) {
                answers[i].answer = randomChoice();
                answers[i].num = randomNum(10);
            }
        }

        static void calcProcent(Answer[] answers, int n) {
            int sum = 0;
            for (int i = 0; i < n; i++) {
                sum += answers[i].num;
            }
            for (int i = 0; i < n; i++) {
                answers[i].procent = (double)answers[i].num / (double)sum * 100;
            }
        }

        static void printAnswers(Answer[] answers) {
            foreach (Answer p in answers)
            {
                Console.WriteLine("{0}: {2:0.00} ({1})", p.answer, p.num, p.procent);
            }
        }

        static void fullSpResults(Sportsman[] sportsmen, int n) {
            Random r = new Random();
            for (int i = 0; i < n; i++) {
                sportsmen[i] = new Sportsman(randomChoice(), r.Next(10), r.Next(10));
            }
        }

        static void printSportsmen(Sportsman[] sportsmen) {
            foreach (Sportsman sp in sportsmen)
            {
                Console.WriteLine("{0}: {1}", sp.name, sp.best);
            }
        }

        static void fullStudentsInfo(Student[] students, int n) {
            Random r = new Random();
            for (int i = 0; i < n; i++) {
                students[i].mark = r.Next(6);
                students[i].missedLessons = r.Next(10);
                students[i].name = randomChoice();
            }
        }
        static void printStudents(Student[] students) {
            foreach (Student s in students)
            {
                Console.WriteLine("{0}: оценка {1}, пропущено {2} занятий", s.name, s.mark, s.missedLessons);
            }
        }

        static void Main(string[] args) {
            Console.WriteLine("3 задача");
            Console.Write("Количество ответов: ");
            int n = int.Parse(Console.ReadLine());
            Answer[] answers = new Answer[n];
            fullAnswers(answers, n);
            Console.WriteLine("Ответы исходные");
            printAnswers(answers);
            calcProcent(answers, n);
            answers = answers.OrderBy(ans => ans.num).Reverse().Take(5).ToArray();
            Console.WriteLine("\nОтветы отсортированные");
            printAnswers(answers);


            Console.WriteLine("\n\n4 задача");
            Console.Write("Количество спортсменов: ");
            int n2 = int.Parse(Console.ReadLine());
            Sportsman[] sportsmen = new Sportsman[n2];
            fullSpResults(sportsmen, n2);
            Console.WriteLine("Спортсмены с исходными данными");
            printSportsmen(sportsmen);
            sportsmen = sportsmen.OrderBy(sp => sp.best).Reverse().ToArray();
            Console.WriteLine("\nСпортсмены отсортированные");
            printSportsmen(sportsmen);


            Console.WriteLine("\n\n5 задача");
            Console.Write("Количество студентов: ");
            int n3 = int.Parse(Console.ReadLine());
            Student[] students = new Student[n3];
            fullStudentsInfo(students, n3);
            Console.WriteLine("Студенты с исходными данными");
            printStudents(students);
            students = students.Where(s => s.mark == 2).OrderBy(s => s.missedLessons).Reverse().ToArray();
            Console.WriteLine("\nСтуденты отсортированные");
            printStudents(students);
        }
    }
}
