using System;
using System.Numerics; // Пространство имен числовых типов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjectByDotsenko
{
    public class LabThreeTaskTwo
    {
        public void Run()
        {
            List<int> numbers = ReadInput(); //Вызов метода ReadInput, сохранение результата в List
            FindMax(numbers); //Вызов метода поиска максимального числа
        }
        
        private static void FindMax(List<int> numbers)
        {
            if (numbers.Count == 0) //Если размер List равен 0, то вывод сообщения
            {
                Console.WriteLine("Числа не были введены");
                return;
            }
            else //Вывод максимального числа
            {
                Console.WriteLine("Максимальное число в последовательности: " + numbers.Max());
            }
        }
        private static List<int> ReadInput()
        {
            List<int> inputMassive = new List<int>(); // Создание пустого массива для ввода
            Console.WriteLine("Введите последовательно положительные числа. Для выхода введите 0");
            while (true) //Вход в цикл, выход из которого через ввод 0
            {
                string inputString = Console.ReadLine(); //Ввод от пользователя
                try
                {
                    int inputNum = int.Parse(inputString); //Попытка парсить в int
                    if (inputNum == 0) //Если ввод 0, выходим из цикла
                    {
                        break;
                    }
                    else if (inputNum < 0) //Если число меньше 0, вывод сообщения
                    {
                        Console.WriteLine("Ошибка: Вводите ТОЛЬКО положительные числа");
                    }
                    else // Иначе добавляем в массив
                    {
                        inputMassive.Add(inputNum); //Добавление в массив значения
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода числа.  Введите любое число или 0 для завершения программы");
                }
            }
            return inputMassive;
        }
    }
}
