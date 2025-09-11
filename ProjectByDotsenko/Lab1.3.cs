using System;


namespace ProjectByDotsenko
{
    public class LabTwoTaskThree
    {
        public void Run()
        {
            Console.Write("Введите число a: "); //Запрос ввода
            int a = int.Parse(Console.ReadLine()); //Ввод числа a
            int a2 = a * a; //Возведение в 2 степень
            int a4 = a2 * a2; //Возведение в 4 степень
            int a8 = a4 * a4; //Возведение в 8 степень
            long a12 = a8 * a4; //Возведение в 12 степень
            long a28 = a12 * a12 * a4; //Возведение в 28 степень
            Console.WriteLine($"Число в 12 степени: {a12}, в 28 степени: {a28}"); //Вывод в консоль
        }
    }
}
