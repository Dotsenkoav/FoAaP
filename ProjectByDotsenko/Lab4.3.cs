using System;
using System.Linq;

namespace ProjectByDotsenko
{
    public class LabFourTaskThree
    {
        public void Run() //Главное тело класса
        {
            int N = readInput();
            int[] startArray = generateArray(N);
            Console.Write($"Для массива: ");
            foreach (int i in startArray) //Вывод массива
            {
                Console.Write(i + " ");
            }
            sortArray(startArray); //Находим кол-во элементов по условию
            Console.WriteLine();
            Console.WriteLine("Сортировка: ");
            foreach (int i in startArray) //Вывод массива
            {
                Console.Write(i + " ");
            }
        }


        internal static void sortArray(int[] inputArray)
        {
            int maxElement = inputArray[0];
            int maxIndex = 0;
            for (int i = 1; i < inputArray.Length; i++) //Находим максимальный элемент и его индекс
            {
                if (inputArray[i] > maxElement)
                {
                    maxElement = inputArray[i];
                    maxIndex = i;
                }
            }

            for(int i = 0; i < maxIndex; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j <= maxIndex; j++)
                {
                    if (inputArray[j] < inputArray[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = inputArray[i];
                    inputArray[i] = inputArray[minIndex];
                    inputArray[minIndex] = temp;
                }
            }

            for (int i = maxIndex + 1; i < inputArray.Length; i++)
            {
                int maxIndexSub = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] > inputArray[maxIndexSub])
                    {
                        maxIndexSub = j;
                    }
                }
                if (maxIndexSub != i)
                {
                    int temp = inputArray[i];
                    inputArray[i] = inputArray[maxIndexSub];
                    inputArray[maxIndexSub] = temp;
                }
            }
        }



        internal static int readInput() //Ввод пользователя
        {
            int inputNum;
            while (true)
            {
                Console.Write("Введите натуральное целое число: ");
                string inputText = Console.ReadLine();
                try
                {
                    inputNum = int.Parse(inputText); //Попытка парсить
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка: Введите натуральное целое число");
                }
            }
            return inputNum;
        }

        internal static int[] generateArray(int N) //Генерация массива
        {
            int[] randomArray = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                randomArray[i] = random.Next(1, 100);
            }
            return randomArray;
        }

    }
}

