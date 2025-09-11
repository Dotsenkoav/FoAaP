using System;

namespace ProjectByDotsenko
{
    public class LabTwoTaskOne
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
