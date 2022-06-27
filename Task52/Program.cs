internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        void PrintArray(int[,] twodimArray) //метод вывода массива на печать
        {
            for (int i = 0; i < twodimArray.GetLength(0); i++) //цикл для задания строк
            {
                for (int j = 0; j < twodimArray.GetLength(1); j++) //цикл для задания столбцов
                {
                    Console.Write($"{twodimArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        void FillArray(int[,] twodimArray) //метод заполнения массива
        {
            for (int i = 0; i < twodimArray.GetLength(0); i++) //цикл для задания строк
            {
                for (int j = 0; j < twodimArray.GetLength(1); j++) //цикл для задания столбцов
                {
                    twodimArray[i, j] = new Random().Next(0, 10);
                }
            }
        }
        Random rndRows = new Random();
        Random rndcolumns = new Random();
        int[,] matrix = new int[rndRows.Next(2, 4), rndcolumns.Next(3, 5)];
        FillArray(matrix);
        Console.WriteLine();
        Console.WriteLine("Создаю случайный двумерный массив... Массив создан!");
        PrintArray(matrix);
        //Console.WriteLine(matrix.GetLength(0));
        Console.WriteLine("Среднее арифметическое для каждого столбца будет: ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, j];
            }
            Console.Write("{0,6:F1}", sum / matrix.GetLength(0));
        }
    }
}