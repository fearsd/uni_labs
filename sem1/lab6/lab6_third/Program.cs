using System;
using System.Linq;

namespace lab6_third
{

    struct Sportsman
    {
        public string name;
        public int result;
    }


    struct Match {
        public string team1;
        public string team2;
        public int scoredGoals;
        public int missedGoals;

        public Match(string team1, string team2, int scoredGoals, int missedGoals) {
            this.team1 = team1;
            this.team2 = team2;
            this.scoredGoals = scoredGoals;
            this.missedGoals = missedGoals;
        }
    }

    class Team {
        public string name;
        public int score = 0;
        public int scoredGoals = 0;
        public int missedGoals = 0;
        public int numMatches = 1;
        public int diff; // scoredGoals - missedGoals
        public Team(string name, int scoredGoals, int missedGoals, int score) {
            this.name = name;
            this.score = score;
            this.scoredGoals = scoredGoals;
            this.missedGoals = missedGoals;
            this.diff = this.scoredGoals - this.missedGoals;
        }
        public void Update(int scoredGoals, int missedGoals, int score) {
            this.scoredGoals += scoredGoals;
            this.missedGoals += missedGoals;
            this.score += score;
            this.diff = this.scoredGoals - this.missedGoals;
            this.numMatches++;
        }
        
    }

    struct Answer {
        public string answer1 = "";
        public string answer2 = "";
        public string answer3 = "";

        public Answer(string answer1 = "", string answer2 = "", string answer3 = "") {
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.answer3 = answer3;
        }
    }

    class OptionAnswer {
        public string answer;
        public int num;
        public int answerNum;
        public double procent = 0;

        public OptionAnswer(string answer, int num, int answerNum) {
            this.answer = answer;
            this.num = num;
            this.answerNum = answerNum;
        }
    }



    class Program
    {
        static int randomNum(int numEnd) {
            Random random = new Random();
            return random.Next(numEnd);
        }

        static string randomChoice() {
            string[] choices = {
                "Мика Мюллюля", "Юха Мието", "Эдди Сикстен Йернберг", "Вегард Ульванг",
                "Томас Вассберг", "Томас Альсгорд", "Петтер Нортуг", "Владимир Смирнов",
                "Гунде Сван", "Бьорн Дэли"
            };
            return choices[randomNum(choices.Count())];
        }

        static void fullSportsmen(Sportsman[] sportsmen, int n) {
            for (int i = 0; i < n; i++) {
                sportsmen[i].name = randomChoice();
                sportsmen[i].result = randomNum(20);
            }
        }

        static void printSportsmen(Sportsman[] sportsmen) {
            int n = sportsmen.GetLength(0);
            Sportsman sp;
            for (int i = 0; i < n; i++) {
                sp = sportsmen[i];
                Console.WriteLine("{0}. {1} | {2}", i+1, sp.name, sp.result);
            }
        }

        static int getScore(int scoredGoals, int missedGoals) {
            if (scoredGoals > missedGoals) return 3;
            else if (scoredGoals < missedGoals) return 0;
            else return 1;

        }

        
        static void countMatch(Match match, List<Team> teams, bool isGuest=false) {
            string teamName = !isGuest ? match.team1 : match.team2;
            if (isGuest) {
                int p = match.missedGoals;
                match.missedGoals = match.scoredGoals;
                match.scoredGoals = p;
            }
            int queryResult = teams.Where(t => t.name == teamName).ToArray().Count();
            if (queryResult != 0) {
                Team team = teams.Where(t => t.name == teamName).ToArray()[0];
                team.Update(match.scoredGoals, match.missedGoals, getScore(match.scoredGoals, match.missedGoals));
            }
            else {
                teams.Add(new Team(teamName, match.scoredGoals, match.missedGoals, getScore(match.scoredGoals, match.missedGoals)));
            }
        }

        static void SortTeams(List<Team> teams) {
            int n = teams.Count();
            Team temp;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n - 1; j++) {
                    if (teams[j].score < teams[j+1].score) {
                        temp = teams[j + 1];
                        teams[j + 1] = teams[j];
                        teams[j] = temp;
                    }
                    else if (teams[j].score == teams[j+1].score && teams[j].diff < teams[j+1].diff) {
                        temp = teams[j + 1];
                        teams[j + 1] = teams[j];
                        teams[j] = temp;
                    }
                }
            }
        }

        static void conductVotes(Answer[] answers, List<OptionAnswer> optionAnswers) {
            foreach (Answer ans in answers) {
                bool isAnswerInList1 = optionAnswers.Where(_ans => (_ans.answer == ans.answer1) && (_ans.answerNum == 1)).Count() == 0;
                bool isAnswerInList2 = optionAnswers.Where(_ans => (_ans.answer == ans.answer2) && (_ans.answerNum == 2)).Count() == 0;
                bool isAnswerInList3 = optionAnswers.Where(_ans => (_ans.answer == ans.answer3) && (_ans.answerNum == 3)).Count() == 0;
                if ((ans.answer1 != "") && isAnswerInList1) {
                    optionAnswers.Add(new OptionAnswer(ans.answer1, 1, 1));
                }
                else if ((ans.answer1 != "") && !isAnswerInList1) {
                    OptionAnswer optAnswer = optionAnswers.Where(_ans => (_ans.answer == ans.answer1) && (_ans.answerNum == 1)).ToList()[0];
                    optAnswer.num += 1;
                }

                if ((ans.answer2 != "") && isAnswerInList2) {
                    optionAnswers.Add(new OptionAnswer(ans.answer2, 1, 2));
                }
                else if ((ans.answer2 != "") && !isAnswerInList2) {
                    OptionAnswer optAnswer = optionAnswers.Where(_ans => (_ans.answer == ans.answer2) && (_ans.answerNum == 2)).ToList()[0];
                    optAnswer.num += 1;
                }

                if ((ans.answer3 != "") && isAnswerInList3) {
                    optionAnswers.Add(new OptionAnswer(ans.answer3, 1, 3));
                }
                else if ((ans.answer3 != "") && !isAnswerInList3) {
                    OptionAnswer optAnswer = optionAnswers.Where(_ans => (_ans.answer == ans.answer3) && (_ans.answerNum == 3)).ToList()[0];
                    optAnswer.num += 1;
                }
            }
        }

        static void countProcent(OptionAnswer[] optionAnswers) {
            int sum = 0;
            foreach (OptionAnswer ans in optionAnswers)
            {
                sum += ans.num;
            }
            foreach (OptionAnswer ans in optionAnswers)
            {
                ans.procent = (double)ans.num / (double)sum * 100.0;
            }
        }

        static void printResultVotes(OptionAnswer[] optionAnswers) {
            foreach (OptionAnswer ans in optionAnswers)
            {
                Console.WriteLine("{0} {1} {2:0.00}%", ans.answer, ans.num, ans.procent);
            }
        }

        static void Main(string[] args) {
            Console.WriteLine("задача 4");
            Console.Write("Введите количество лыжников в первой группе: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите количество лыжников в второй группе: ");
            int n2 = int.Parse(Console.ReadLine());

            Sportsman[] sportsmenGroup1 = new Sportsman[n1];
            fullSportsmen(sportsmenGroup1, n1);
            Sportsman[] sportsmenGroup2 = new Sportsman[n2];
            fullSportsmen(sportsmenGroup2, n2);

            Console.WriteLine("группа 1 до сортировки");
            printSportsmen(sportsmenGroup1);
            Console.WriteLine("\nгруппа 2 до сортировки");
            printSportsmen(sportsmenGroup2);


            sportsmenGroup1 = sportsmenGroup1.OrderBy(sp => sp.result).Reverse().ToArray();
            sportsmenGroup2 = sportsmenGroup2.OrderBy(sp => sp.result).Reverse().ToArray();

            Console.WriteLine("\nгруппа 1 с сортировкой");
            printSportsmen(sportsmenGroup1);
            Console.WriteLine("\nгруппа 2 с сортировкой");
            printSportsmen(sportsmenGroup2);

            Sportsman[] unifiedSportsmen = sportsmenGroup1.Concat(sportsmenGroup2).ToArray();
            unifiedSportsmen = unifiedSportsmen.OrderBy(sp => sp.result).Reverse().ToArray();

            Console.WriteLine("\nобъединенная группа: ");
            printSportsmen(unifiedSportsmen);



            // задача 5
            List<Team> teams = new List<Team>();
            Match[] matches = {
                new Match("Германия", "Япония", 1, 2),
                new Match("Испания", "Коста-Рика", 7, 0),

                new Match("Япония", "Коста-Рика", 0, 1),
                new Match("Испания", "Германия", 1, 1),

                new Match("Япония", "Испания", 2, 1),
                new Match("Коста-Рика", "Германия", 2, 4),
            };

            foreach (Match m in matches) {
                countMatch(m, teams);
                countMatch(m, teams, isGuest: true);
            }
            SortTeams(teams);
            Console.WriteLine("   Название  Очки  ЗМ  ПМ  Раз  Матчи");
            foreach (Team t in teams) {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", t.name, t.score, t.scoredGoals, t.missedGoals, t.diff, t.numMatches);
            }

            // задача 6
            Answer[] answers = {
                new Answer("", "", ""), new Answer("", "", ""),
                new Answer("панда", "терпеливость", "рис"), new Answer("собака", "доброта", "счастье"),
                new Answer("", "доброта", "аниме"), new Answer("панда", "терпеливость", ""),
                new Answer("", "терпеливость", ""), new Answer("обезьяна", "трудолюбие", "музыка"),
                new Answer("кошка", "доброта", ""), new Answer("", "терпеливость", "рис"),
                new Answer("панда", "терпеливость", "игры"), new Answer("собака", "чистоплотность", "солнце"),
            };
            List<OptionAnswer> optionAnswers = new List<OptionAnswer>();
            conductVotes(answers, optionAnswers);
            OptionAnswer[] optionAnswers1 = optionAnswers.Where(ans => ans.answerNum == 1).OrderBy(ans => ans.num).Reverse().Take(5).ToArray();
            countProcent(optionAnswers1);
            OptionAnswer[] optionAnswers2 = optionAnswers.Where(ans => ans.answerNum == 2).OrderBy(ans => ans.num).Reverse().Take(5).ToArray();
            countProcent(optionAnswers2);
            OptionAnswer[] optionAnswers3 = optionAnswers.Where(ans => ans.answerNum == 3).OrderBy(ans => ans.num).Reverse().Take(5).ToArray();
            countProcent(optionAnswers3);


            Console.WriteLine("Первый вопрос");
            printResultVotes(optionAnswers1);
            Console.WriteLine("Второй вопрос");
            printResultVotes(optionAnswers2);
            Console.WriteLine("Третий вопрос");
            printResultVotes(optionAnswers3);

        }
    }
}
