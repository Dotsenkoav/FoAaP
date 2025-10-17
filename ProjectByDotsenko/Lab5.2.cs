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
    public class LabFiveTaskTwo
    {
        public void Run() //Главный класс подпрограммы
        {
            for (int i = 15; i <= 30; i++)
            {
                Console.WriteLine($"f({i}) = {MyRecursFn(i)}");
            }
        }

        internal int MyRecursFn(int n)
        {
            if (n == 1) return 1;
            int sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum += MyRecursFn(n / i);
            }
            return sum;
        }
    }
}
