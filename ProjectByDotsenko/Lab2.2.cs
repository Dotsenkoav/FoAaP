using System;
using System.Numerics; // Пространство имен числовых типов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjectByDotsenko
{
    internal class LabTwoTaskTwo
    {
        static void Main(string[] args)
        {
            List<int> inputMassive = new List<int>(); // Создание пустого массива
            Console.WriteLine("Введите последовательно положительные числа");
            while (true) //Вход в цикл, выход из которого через ввод 0
            {
                string inputString = Console.ReadLine();
                try
                {
                    int inputNum = int.Parse(inputString);
                    if (inputNum == 0)
                    {
                        break;
                    }
                    else if (inputNum < 0)
                    {
                        Console.WriteLine("Введенно отрицательное число, возможен ввод ТОЛЬКО положительного");
                    }
                    else {
                        inputMassive.Add(inputNum); //Добавление в массив значения
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода числа. Введите любое число или 0 для завершения программы");
                    inputMassive.Clear();
                }
            }
            if (inputMassive.Count == 0)
            {
                Console.WriteLine("Отсутствует ввод значения");
            }
            else
            {
                Console.WriteLine("Максимальное число в последовательности: " + inputMassive.Max());
            }
        }
    }
}
