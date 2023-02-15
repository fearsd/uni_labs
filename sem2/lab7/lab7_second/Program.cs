using System;


namespace lab7_second {
    
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
    class Student {
        public int math;
        public int physics;
        public int russian;
        public double average;
        public string name;

        public Student(int math, int physics, int russian, string name) {
            this.math = math;
            this.physics = physics;
            this.russian = russian;
            this.name = name;
            this.average = (math + physics + russian) / 3;
        }
    }

    class StudentExtended : Student {

        public StudentExtended(int math, int physics, int russian, string name) : base(math, physics, russian, name) {}

        public static void fullStudentsInfo(StudentExtended[] students, int n) {
            Random r = new Random();
            for (int i = 0; i < n; i++) {
                students[i] = new StudentExtended(r.Next(2, 6), r.Next(2, 6), r.Next(2, 6), Helper.randomChoice());
            }
        }
        public static void printStudents(StudentExtended[] students) {
            foreach (Student s in students)
            {
                Console.WriteLine("{0}: средняя оценка {1}, ({2}, {3}, {4})", s.name, s.average, s.math, s.physics, s.russian);
            }
        }

        
    }

    class Sportsman {
        public string name;
        public int res1;
        public int res2;
        public int res3;

        public int best;

        public Sportsman(string name, int res1, int res2, int res3) {
            this.name = name;
            this.res1 = res1;
            this.res2 = res2;
            this.res3 = res3;
            this.best = new [] { res1, res2, res3 }.Max();
        }
    }

    class SportsmanExtended : Sportsman {
        public SportsmanExtended(string name, int res1, int res2, int res3) : base(name, res1, res2, res3) {}
        public static void fullSportsmenInfo(SportsmanExtended[] sportsmen, int n) {
            Random r = new Random();
            for (int i = 0; i < n; i++) {
                sportsmen[i] = new SportsmanExtended(Helper.randomChoice(), r.Next(10), r.Next(10), r.Next(10));
            }
        }
        public static void printSportsmen(SportsmanExtended[] students) {
            foreach (SportsmanExtended s in students)
            {
                Console.WriteLine("{0}: лучшая попытка {1}", s.name, s.best);
            }
        }
    }

    class Program {
        
        
        static void Main(string[] args) {
            Console.WriteLine("3 задача");
            Console.Write("Количество студентов: ");
            int n = int.Parse(Console.ReadLine());
            StudentExtended[] students = new StudentExtended[n];
            StudentExtended.fullStudentsInfo(students, n);
            Console.WriteLine("Студенты с исходными данными");
            StudentExtended.printStudents(students);
            students = students.Where(s => (s.math != 2 && s.physics != 2 && s.russian != 2))
                                .OrderBy(s => s.average)
                                .Reverse().ToArray();
            Console.WriteLine("\nСтуденты отсортированные");
            StudentExtended.printStudents(students);

            Console.WriteLine("4 задача");
            Console.Write("Количество спортсменов: ");
            int n2 = int.Parse(Console.ReadLine());
            SportsmanExtended[] sportsmen = new SportsmanExtended[n2];
            SportsmanExtended.fullSportsmenInfo(sportsmen, n2);
            Console.WriteLine("Спортсмены с исходными данными");
            SportsmanExtended.printSportsmen(sportsmen);
            sportsmen = sportsmen.OrderBy(s => s.best)
                                    .Reverse().ToArray();
            Console.WriteLine("\nСпортсмены отсортированные");
            SportsmanExtended.printSportsmen(sportsmen);            

        }
    }
}
