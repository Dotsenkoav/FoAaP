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
            Console.WriteLine("Выберите задачу: 2.1, 2.3, 2.4, 3.1, 3.2, 4.1, 4.2");

            string choose = Console.ReadLine(); 

            switch(choose)
            {
                case "2.1":
                    LabTwoTaskOne lab11 = new LabTwoTaskOne();
                    lab11.Run();
                    break;
                case "2.3":
                    LabTwoTaskThree lab13 = new LabTwoTaskThree();
                    lab13.Run();
                    break;
                case "2.4":
                    LabTwoTaskFour lab14 = new LabTwoTaskFour();
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
                case "4.1":
                    LabFourTaskOne lab41 = new LabFourTaskOne();
                    lab41.Run();
                    break;
                case "4.2":
                    LabFourTaskTwo lab42 = new LabFourTaskTwo();
                    lab42.Run();
                    break;
            }
        }
    }
}
