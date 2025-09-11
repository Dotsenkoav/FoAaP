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
    public class LabFiveTaskOne
    {
        public void Run() //Главный класс подпрограммы
        {
            Console.Write("Введите строку: ");
            string inputString = readInput();
            string upperInput = upperString(inputString);
            Console.WriteLine("Строка в верхнем регистре: " + upperInput);
            Console.Read();
        }

        internal string upperString(string lowerString) //Метод принимающий строку и преобразующий её буквы в заглавные
        {
            string result = lowerString.ToUpper();
            return result;
        }

        internal string readInput() //Метод считывающий ввод с клавиатуры
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
