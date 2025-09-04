using System;
using System.Numerics; // Пространство имен числовых типов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjectByDotsenko
{
    internal class LabOneTaskFour
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длительность разговора: "); // Запрос ввода длительности разговора
            int durationTalk = int.Parse(Console.ReadLine()); // Ввод от пользователя длительности разговора
            Console.Write("Введите день недели цифрой: "); // Запрос дня недели
            int dayOfWeek = int.Parse(Console.ReadLine()); // Ввод от пользователя дня недели
            int cost = 20; // Цена тарифа за минуту
            if (dayOfWeek < 1 || dayOfWeek > 7) // Если день недели не входит в диапазон 1 - 7
            {
                Console.WriteLine("Введен некорректный день недели");
            }
            else if (dayOfWeek == 6 || dayOfWeek == 7) // Если день недели выходной (6 или 7), то скидка
            {
                Console.WriteLine("Цена разговора: " + (cost * durationTalk * 0.8));
            }
            else // Иначе обычная стоимость
            {
                Console.WriteLine("Цена разговора: " + (cost * durationTalk));
            }
        }
    }
}
