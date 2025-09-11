using System;


namespace ProjectByDotsenko
{
    public class LabFourTaskTwo
    {
        public void Run() //Главный метод класса
        {
            var (rowsInput, columnsInput) = readInput(); //Считываем размерность матрицы
            int[,] randomArray = generateArray(rowsInput, columnsInput); //Генерируем двумерный массив со случайными числами
            Console.WriteLine("Начальная матрица:");
            outputArray(randomArray); //Вывод генерируемой матрицы
            modifyArray(randomArray); //Модифицируем матрицу, изменяя главную диагональ и выше на 0
            Console.WriteLine("Модифицированная матрица:");
            outputArray(randomArray); //Вывод матрицы после преобразования
        }

        internal static void modifyArray(int[,] inputArray) //Метод модифицирующий матрицу
        {
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    if (i <= j)
                    {
                        inputArray[i, j] = 0;
                    }
                }
            }
        }

        internal static int[,] generateArray(int rows, int columns) //Метод генерирующий матрицу и заполняющий случайными числами
        {
            int[,] array = new int[rows, columns];
            Random random = new Random();
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns ; j++)
                {
                    array[i, j] = random.Next(1, 1000);
                }
            }
            return array;
        }

        internal void outputArray(int[,] array) //Метод вывода матрицы
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        internal static (int rows, int columns) readInput() //Метод считывания
        {
            int rows;
            int columns;
            while (true)
            {
                Console.Write("Введите кол-во строк матрицы: ");
                string iStr = Console.ReadLine();
                Console.Write("Введите кол-во стобцов матрицы: ");
                string jStr = Console.ReadLine();
                try
                {
                    rows = int.Parse(iStr);
                    columns = int.Parse(jStr);
                    if (rows <= 0 || columns <= 0)
                    {
                        Console.WriteLine("Ошибка: Числа должны быть положительными");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка: Введите натуральные целые числа");
                }
            }
            return (rows, columns);
        }
    }
}

