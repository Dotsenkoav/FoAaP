using System;
using System.Numerics; // Пространство имен числовых типов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;

namespace ProjectByDotsenko
{
    public class LabFourTaskOne
    {
        public void Run()
        {
            int N = ReadInput();
            int[] generatedRandomArray = GenerateArray(N);
            Console.Write($"Для массива:");
            foreach (int i in generatedRandomArray)
            {
                Console.Write(i + " ");
            }
            int result = findMult(generatedRandomArray);
            Console.WriteLine();
            Console.Write("Кол-во элементов кратных 3, но не кратным 5: " + result);
        }

        internal static int findMult(int[] inputArray)
        {
            int sum = 0;
            foreach (int i in inputArray)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    sum += 1;
                    return sum;
                }
            }
            return sum;
        }

        internal static int[] GenerateArray(int N)
        {
            int[] randomArray = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                randomArray[i] = random.Next(1, 100);
            }
            return randomArray;
        }
        internal static int ReadInput()
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

