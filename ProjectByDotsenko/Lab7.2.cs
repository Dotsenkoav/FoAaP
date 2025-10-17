using System;
using System.Collections.Generic;
using System.IO;


namespace ProjectByDotsenko
{
    internal class LabSevenTaskTwo
    {
        public void Run()
        {
            Worker[] workers = new Worker[0];
            string filepath = "workers.txt";
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Ввод данных о сотрудниках");
                Console.WriteLine("2 - Чтение данных из файла");
                Console.WriteLine("3 - Вывод на экран работников, чей стаж превышает введенное число");
                Console.WriteLine("4 - Выход из программы");

                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        workers = InputData();
                        SaveFile(workers, filepath);
                        continue;
                    case "2":
                        workers = ReadFile(filepath);
                        OutputWorkers(workers);
                        continue;
                    case "3":
                        if (workers.Length == 0)
                        {
                            Console.WriteLine("Сначала загрузите данные (пункт 1 или 2)");
                        }
                        else 
                        { 
                            CheckExp(workers);
                        }
                        continue;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод");
                        continue;
                }

            }
        }

        public struct Worker
        {
            public string fullName;
            public string position;
            public int startYear;

            public Worker (string fullName, string position, int startYear)
            {
                this.fullName = fullName;
                this.position = position;
                this.startYear = startYear;
            }
        }

        public Worker[] InputData()
        {
            Worker[] workers = new Worker[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Работник номер {i + 1}");
                Console.Write("Введите Фамилию и инициалы: ");
                workers[i].fullName = Console.ReadLine();

                Console.Write("Введите должность: ");
                workers[i].position = Console.ReadLine();

                int year;
                while (true)
                {
                    Console.Write("Введите год приёма: ");
                    if (int.TryParse(Console.ReadLine(), out year) && year >= 1900 && year <= DateTime.Now.Year)
                        break;
                    Console.WriteLine("Неверный формат года! Введите число от 1900 до текущего года!");
                }
                workers[i].startYear = year;
            }
            return workers;
        }

        public void SaveFile(Worker[] workers, string filepath)
        {
            try
            {
                string fullPath = Path.GetFullPath(filepath);
                Console.WriteLine($"Попытка записи в {fullPath}");

                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    foreach (Worker worker in workers)
                    {
                        writer.WriteLine($"{worker.fullName}|{worker.position}|{worker.startYear}");
                    }
                }
                Console.WriteLine($"Успешная запись сотрудников в файл {fullPath}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка записи в файл workers.txt: {e.Message}");
            }
        }

        public Worker[] ReadFile(string filepath)
        {
            List<Worker> workers = new List<Worker>();
            try
            {
                if (!File.Exists(filepath))
                {
                    Console.WriteLine("Файл не найден! Сначала введите данные.");
                    return new Worker[0];
                }

                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    int lineNumber = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        lineNumber++;

                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] parts = line.Split('|');

                        string fullName = parts[0];
                        string position = parts[1];
                        int startYear = int.Parse(parts[2]);

                        workers.Add(new Worker(fullName, position, startYear));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка чтения файла: {e.Message}");
                return new Worker[0];
            }

            Console.WriteLine($"Загружено {workers.Count} сотрудников");
            return workers.ToArray();
        }

        public void OutputWorkers(Worker[] workers)
        {
            Console.WriteLine("|==================|=========================|==================|");
            Console.WriteLine("|       ФИО        |         Должность       |    Год приёма    |");
            Console.WriteLine("|==================|=========================|==================|");

            foreach (Worker worker in workers) 
            {
                Console.WriteLine($"| {worker.fullName,-16} | {worker.position,-23} | {worker.startYear,-16} |");
            }
            Console.WriteLine("|==================|=========================|==================|");
        }

        public void CheckExp(Worker[] workers)
        {
            List<Worker> workerExpList = new List<Worker>();


            Console.WriteLine("Введите минимальный стаж (в годах):");
            int exp = int.Parse(Console.ReadLine());


            foreach (Worker worker in workers)
            {
                if ((DateTime.Now.Year - worker.startYear) >= exp)
                {
                    workerExpList.Add(worker);
                }
            }

            workerExpList.Sort((w1, w2) => w1.fullName.CompareTo(w2.fullName));

            if (workerExpList.Count > 0)
            {
                Console.WriteLine("===============================================");
                Console.WriteLine($"Список сотрудников со стажем больше {exp} лет:");

                foreach (Worker w in workerExpList)
                {
                    Console.WriteLine(w.fullName);
                }
                Console.WriteLine("===============================================");
            }
            else
            {
                Console.WriteLine($"Сотрудников со стажем больше {exp} лет не найдено!");
            }
        }


    }
}