using System;

namespace ProjectByDotsenko
{
    public class LabFourTaskOne
    {
        public void Run() //Главное тело класса
        {
            int N = ReadInput(); //Считываем длину массива
            int[] generatedRandomArray = GenerateArray(N); //Создаем массив и заполняем случайными числами
            Console.Write($"Для массива:");
            foreach (int i in generatedRandomArray) //Вывод массива
            {
                Console.Write(i + " ");
            }
            int result = findMult(generatedRandomArray); //Находим кол-во элементов по условию
            Console.WriteLine();
            Console.Write("Кол-во элементов кратных 3, но не кратным 5: " + result);
        }

        internal static int findMult(int[] inputArray) //Поиск кол-ва элементов кратным 3, но не кратным 5
        {
            int sum = 0;
            foreach (int i in inputArray)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    sum += 1;
                }
            }
            return sum;
        }

        internal static int[] GenerateArray(int N) //Генерация массива
        {
            int[] randomArray = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                randomArray[i] = random.Next(1, 100);
            }
            return randomArray;
        }
        internal static int ReadInput() //Ввод пользователя
        {
            int inputNum;
            while (true)
            {
                string inputText = Console.ReadLine();
                try
                {
                    inputNum = int.Parse(inputText); //Попытка парсить
                    if (inputNum <= 0)
                    {
                        Console.WriteLine("Ошибка: Число должно быть положительным");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка: Введите натуральное целое число");
                }
            }
            return inputNum;
        }
    }
}

