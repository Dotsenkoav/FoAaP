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
    internal class LabSixTaskThree
    {
        public void Run()
        {
            string inputText = "lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
            string text = UpperInput(inputText);
            Console.WriteLine(text);
        }

        public string UpperInput(string input)
        {
            string result = "";
            result = Regex.Replace(input, @"(\b)(\S)", match => match.ToString().ToUpper() );
            return result;
        }
    }
}