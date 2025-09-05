using System;
using System.Numerics; // Пространство имен числовых типов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace ProjectByDotsenko
{
    public class LabThreeTaskOne
    {
        public void Run() //Главный класс подпрограммы
        {
            Console.Write("Введите кол-во N: "); //Вывод сообщения о вводе
            int N = ReadInput(); //Вызов метод ReadInput() и сохранение результата в переменную
            if (N < 0) //Проверка числа, если отрицательное вывод сообщения
            {
                Console.WriteLine("N должно быть положительным числом");
            }
            else 
            {
                int sum = Calculate(N); //Вызов метода Calculate() и сохранение результата в переменную
                Console.WriteLine($"Сумма первых {N} положительных четных чисел: " + sum); //Вывод результата
            }
        }

        internal static int Calculate(int N) //Метод определяющий сумму первых N положительных четных чисел
        {
            int sum = 0;
            for (int i = 0; i <= N; i++)
            {
                sum += i * 2;
            }
            return sum;
        }

        internal static int ReadInput() //Метод считывающий ввод с клавиатуры и проверяющий ввод на ошибки
        {
            string input = Console.ReadLine();
            try
            {
                return int.Parse(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка, введенно не число");
                throw;
            }
        }
    }
}
