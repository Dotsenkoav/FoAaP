using System;
using System.Numerics; // Пространство имен числовых типов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjectByDotsenko
{
    public class LabOneTaskOne
    {
        public void Run()
        {
            Console.Write("Введите стоимость килограмма яблок: ");
            float costKgApple = float.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("Введите кол-во килограмм яблок: ");
            float weightApple = float.Parse(Console.ReadLine().Replace(".", ","));
            float costApples = costKgApple * weightApple;
            Console.WriteLine($"Стоимость: {costApples}");
            Console.Read();
        }
    }
}
