using System;
using System.Linq;


namespace lab7_first {
    class Helper {
        public static int randomNum(int numEnd) {
            Random random = new Random();
            return random.Next(numEnd);
        }
        public static string randomChoice() {
            string[] choices = {"Путин", "Обама", "Байден", "Месси", "Роналду", "Собянин", "Киркоров", "Басков", "Джек Воробей", "Тим Кук"};
            return choices[randomNum(choices.Count())];
        } 
        
    }
    class Sportsman {
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

    class SportsmanExtended : Sportsman {
        public SportsmanExtended(string name, int res1, int res2) : base(name, res1, res2) {} 
        public static void fullSpResults(SportsmanExtended[] sportsmen, int n) {
            Random r = new Random();
            for (int i = 0; i < n; i++) {
                sportsmen[i] = new SportsmanExtended(Helper.randomChoice(), r.Next(10), r.Next(10));
            }
        }
        public static void printSportsmen(SportsmanExtended[] sportsmen) {
            foreach (SportsmanExtended sp in sportsmen)
            {
                Console.WriteLine("{0}: {1}", sp.name, sp.best);
            }
        }
    }

    class Student {
        public int mark;
        public int missedLessons;
        public string name;

        public Student(int mark, int missedLessons, string name) {
            this.mark = mark;
            this.missedLessons = missedLessons;
            this.name = name;
        }
    }

    class StudentExtended : Student {
        public StudentExtended(int mark, int missedLessons, string name) : base(mark, missedLessons, name) {}
        public static void fullStudentsInfo(StudentExtended[] students, int n) {
            Random r = new Random();
            for (int i = 0; i < n; i++) {
                students[i] = new StudentExtended(r.Next(6), r.Next(10), Helper.randomChoice());
            }
        }
        public static void printStudents(StudentExtended[] students) {
            foreach (StudentExtended s in students)
            {
                Console.WriteLine("{0}: оценка {1}, пропущено {2} занятий", s.name, s.mark, s.missedLessons);
            }
        }
    }

    class Program {
        
        
        static void Main(string[] args) {
            Console.WriteLine("\n\n4 задача");
            Console.Write("Количество спортсменов: ");
            int n2 = int.Parse(Console.ReadLine());
            SportsmanExtended[] sportsmen = new SportsmanExtended[n2];
            SportsmanExtended.fullSpResults(sportsmen, n2);
            Console.WriteLine("Спортсмены с исходными данными");
            SportsmanExtended.printSportsmen(sportsmen);
            sportsmen = sportsmen.OrderBy(sp => sp.best).Reverse().ToArray();
            Console.WriteLine("\nСпортсмены отсортированные");
            SportsmanExtended.printSportsmen(sportsmen);

            Console.WriteLine("\n\n5 задача");
            Console.Write("Количество студентов: ");
            int n3 = int.Parse(Console.ReadLine());
            StudentExtended[] students = new StudentExtended[n3];
            StudentExtended.fullStudentsInfo(students, n3);
            Console.WriteLine("Студенты с исходными данными");
            StudentExtended.printStudents(students);
            students = students.Where(s => s.mark == 2).OrderBy(s => s.missedLessons).Reverse().ToArray();
            Console.WriteLine("\nСтуденты отсортированные");
            StudentExtended.printStudents(students);
        }
    }
}