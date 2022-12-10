using System;

namespace kr {
    class Program {
        static void Main(string[] args) {
            string fileLocation = "m.txt"; //Задаем местоположение файла
            FileStream f = new FileStream(fileLocation, FileMode.Open);// Открываем файлловый поток
            StreamReader rd = new StreamReader(f);//Создаем читатель rd и связываем его с файловым потоком f
            Console.WriteLine(rd.ReadToEnd()); //Считываем все данные из файлового потока и выводим на экран 
            f.Close();// Закрываем файловый поток f

        }
    }
}

