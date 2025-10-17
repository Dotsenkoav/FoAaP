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
    internal class LabSixTaskFour
    {
        public void Run()
        {
            string text1 = "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
            string text2 = "Альшевский И.И. - $1500\n" +
                "Шаран П.П - $10000\n" +
                "Бижбуляк С.С. - $12000\n" +
                "Ермекеев А.А. - $5000";

            Console.WriteLine(UpperText(text1));
            Console.WriteLine(CheckSalary(text2));    
        }

        public string UpperText(string input)
        {
            string result = "";
            result = Regex.Replace(input, @"(\b)(\S)", match => match.ToString().ToUpper());
            return result;
        }

        public string CheckSalary(string input)
        {
            var result = new List<string>();
            MatchCollection employers = Regex.Matches(input, @"^(\w+)\s[А-Я]\.[А-Я]\.?\s*-\s*\$(\d+)", RegexOptions.Multiline);
            
            foreach (Match emp in employers)
            {
                if (int.Parse(emp.Groups[2].Value) >= 9000)
                {
                    result.Add(emp.Groups[1].Value);
                }
            }

            return string.Join(", ", result);
        }
    }
}