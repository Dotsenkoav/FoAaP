using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.IO.Pipelines;
using System.Text.Encodings.Web;
using System.Xml.Serialization;

namespace ProjectByDotsenko
{
    public class LabEightOne
    {
        public void Run()
        {
            Worker[] workers = new Worker[0];
            string filepath = "workers.txt";
            string xmlFilepath = "workers.xml";
            string jsonFilepath = "workers.json";

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Ввод данных и сохранение в .txt");
                Console.WriteLine("2 - Ввод данных и сохранение в XML");
                Console.WriteLine("3 - Ввод данных и сохранение в JSON");
                Console.WriteLine("4 - Чтение данных из файла .txt");
                Console.WriteLine("5 - Чтение данных из файла XML");
                Console.WriteLine("6 - Чтение данных из файла JSON");
                Console.WriteLine("7 - Вывод на экран работников, чей стаж превышает введенное число");
                Console.WriteLine("8 - Выход из программы");

                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        workers = InputData();
                        SaveFile(workers, filepath);
                        continue;
                    case "2":
                        workers = InputData();
                        SaveXML(workers, xmlFilepath);
                        continue;
                    case "3":
                        workers = InputData();
                        SaveJSON(workers, jsonFilepath);
                        continue;
                    case "4":
                        workers = ReadFile(filepath);
                        OutputWorkers(workers);
                        continue;
                    case "5":
                        workers = ReadXML(xmlFilepath);
                        OutputWorkers(workers);
                        continue;
                    case "6":
                        workers = ReadJSON(jsonFilepath);
                        OutputWorkers(workers);
                        continue;
                    case "7":
                        if (workers.Length == 0)
                        {
                            Console.WriteLine("Сначала загрузите данные (пункты 1, 2, 3, 4, 5, 6)");
                        }
                        else 
                        { 
                            CheckExp(workers);
                        }
                        continue;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод");
                        continue;
                }

            }
        }

        public void SaveXML(Worker[] workers, string xmlFilepath)
        {
            try
            {
                string fullPath = Path.GetFullPath(xmlFilepath);
                Console.WriteLine($"Попытка записи в {fullPath}");

                XmlSerializer serializer = new XmlSerializer(typeof(Worker[]));

                using (FileStream fs = new FileStream(xmlFilepath, FileMode.Create))
                {
                    serializer.Serialize(fs, workers);
                }

                Console.WriteLine($"Успешная запись сотрудников в файл {fullPath}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка записи в файл XML: {e.Message}");
            }
        }

        public void SaveJSON(Worker[] workers, string jsonFilepath)
        {
            try
            {
                string fullPath = Path.GetFullPath(jsonFilepath);
                Console.WriteLine($"Попытка записи в {fullPath}");

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };

                using (FileStream fs = new FileStream(jsonFilepath, FileMode.Create))
                {
                    JsonSerializer.Serialize(fs, workers, options);
                }

                Console.WriteLine($"Успешная запись сотрудников в файл {fullPath}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка записи в файл JSON: {e.Message}");
            }
        }

        public Worker[] ReadXML(string xmlFilepath)
        {
            try
            {
                string fullPath = Path.GetFullPath(xmlFilepath);
                Console.WriteLine($"Попытка чтения из XML: {fullPath}");

                XmlSerializer serializer = new XmlSerializer(typeof(Worker[]));

                using (FileStream fs = new FileStream(xmlFilepath, FileMode.Open))
                {
                    Worker[] workers = (Worker[])serializer.Deserialize(fs);
                    Console.WriteLine($"Успешное чтение сотрудников из XML {fullPath}");
                    return workers;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка чтения файла XML: {e.Message}");
                return new Worker[0];
            }
        }

        public Worker[] ReadJSON(string jsonFilepath)
        {
            try
            {
                string fullPath = Path.GetFullPath(jsonFilepath);
                Console.WriteLine($"Попытка чтения из JSON: {fullPath}");

                var options = new JsonSerializerOptions
                {
                    IncludeFields = true
                };

                using (FileStream fs = new FileStream(jsonFilepath, FileMode.Open))
                {
                    Worker [] workers = JsonSerializer.Deserialize<Worker[]>(fs, options);
                    Console.WriteLine($"Успешное чтение сотрудников из JSON {fullPath}");
                    return workers;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка чтения файла JSON: {e.Message}");
                return new Worker[0];
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