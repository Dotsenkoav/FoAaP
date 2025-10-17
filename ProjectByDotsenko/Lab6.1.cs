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
    internal class LabSixTaskOne
    {
        public void Run()
        {
            string inputText = ReadInput();
            Console.WriteLine("Удаление запятых...");
            Console.WriteLine(DeleteComma(inputText));
            Console.WriteLine("Удаление слов в скобках...");
            Console.WriteLine(TrimInput(inputText));
        }

        private static string DeleteComma(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;
            List<string> valid = new List<string>();
            string[] offers = Regex.Split(text, @"([.?!])");


            for (int i = 0; i < offers.Length - 1; i += 2)
            {
                string content = offers[i].Trim();
                string punctuation = offers[i + 1];
                if (offers[i].Contains(","))
                {
                    continue;
                }
                else
                {
                    valid.Add(content + punctuation);
                }
            }

            return string.Join(" ", valid);
        }

        private string TrimInput(string text)
        {
            string result;
            StringBuilder trimText = new StringBuilder();

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
                   trimText.Append(text[i]);
                }
            }
            result = trimText.ToString().Replace("  ", " ");
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
