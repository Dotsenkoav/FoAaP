using System;
using System.Numerics; // Пространство имен числовых типов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace ProjectByDotsenko
{
    public class LabFiveTaskOne
    {
        public void Run() //Главный метод подпрограммы
        {
            Console.Write("Введите строку: ");
            string inputString = ReadInput();
            // string upperInput = UpperString(inputString);
            bool isPolindome = CheckPalindrome(inputString);
            // Console.WriteLine("Строка в верхнем регистре: " + upperInput);
        }

        internal string UpperString(string lowerString) //Метод принимающий строку и преобразующий её буквы в заглавные
        {
            string result = lowerString.ToUpper();
            return result;
        }

        internal bool CheckPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            string reverseText = "";
            text = Regex.Replace(text, @"[\s\p{P}ё]", match => match.Value == "ё" ? "е" : "");
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverseText += text[i];
            }

            if (text.ToLower() == reverseText.ToLower())
            {
                Console.WriteLine("Текст является палиндромом");
                return true;
            }
            else
            {
                Console.WriteLine("Текст не является палиндромом");
                return false;
            }
        }

        internal string ReadInput() //Метод считывающий ввод с клавиатуры
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
