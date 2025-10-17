using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Text;

namespace ProjectByDotsenko
{
    internal class LabSixTaskTwo
    {
        public void Run()
        {
            string inputText = ReadInput();
            StringBuilder trimText = TrimInput(inputText);
            Console.WriteLine(trimText);
            Console.Read();
        }

        private static StringBuilder TrimInput(string text)
        {
            StringBuilder result = new StringBuilder();

            bool startDetect = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    startDetect = true;
                    continue;
                }
                if (text[i] == ')' && startDetect)
                {
                    startDetect = false;
                    continue;
                }
                if (!startDetect)
                {
                    result.Append(text[i]);
                }
            }
            return result;
        }

        private static string ReadInput()
        {
            Console.Write("Введите текст: ");
            string result = Console.ReadLine();
            return result;
        }
    }
}