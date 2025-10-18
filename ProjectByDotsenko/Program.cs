using System;


namespace ProjectByDotsenko
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задачу: 2.1, 2.3, 2.4, 3.1, 3.2, 4.1, 4.2, 4.3, 5.1, 5.2, 6.1, 6.2, 6.3, 6.4, 7.1, 7.2, 8.1");

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
                case "5.1":
                    LabFiveTaskOne lab51 = new LabFiveTaskOne();
                    lab51.Run();
                    break;
                case "5.2":
                    LabFiveTaskTwo lab52 = new LabFiveTaskTwo();
                    lab52.Run();
                    break;
                case "6.1":
                    LabSixTaskOne lab61 = new LabSixTaskOne();
                    lab61.Run();
                    break;
                case "6.2":
                    LabSevenTaskTwo lab62 = new LabSevenTaskTwo();
                    lab62.Run();
                    break;
                case "6.3":
                    LabSixTaskThree lab63 = new LabSixTaskThree();
                    lab63.Run();
                    break;
                case "6.4":
                    LabSixTaskFour lab64 = new LabSixTaskFour();
                    lab64.Run();
                    break;
                case "7.1":
                    LabSevenTaskOne lab71 = new LabSevenTaskOne();
                    lab71.Run();
                    break;
                case "7.2":
                    LabSevenTaskTwo lab72 = new LabSevenTaskTwo();
                    lab72.Run();
                    break;
                case "8.1":
                    LabEightOne lab81 = new LabEightOne();
                    lab81.Run();
                    break;
            }
        }
    }
}
