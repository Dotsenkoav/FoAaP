using System;
using System.Numerics; // Пространство имен числовых типов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjectByDotsenko
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задачу: 1.1, 1.3, 1.4, 2.1, 2.2, 3.1, 3.2");

            string choose = Console.ReadLine(); 

            switch(choose)
            {
                case "1.1":
                    LabOneTaskOne lab11 = new LabOneTaskOne();
                    lab11.Run();
                    break;
                case "1.3":
                    LabOneTaskThree lab13 = new LabOneTaskThree();
                    lab13.Run();
                    break;
                case "1.4":
                    LabOneTaskFour lab14 = new LabOneTaskFour();
                    lab14.Run();
                    break;
                case "3.1":
                    LabThreeTaskOne lab31 = new LabThreeTaskOne();
                    lab31.Run();
                    break;
                case "3.2":
                    LabThreeTaskTwo lab32 = new LabThreeTaskTwo();
                    lab32.Run();
                    break;
            }
        }
    }
}
