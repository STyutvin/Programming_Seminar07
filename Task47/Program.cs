internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
        Console.Write("Задайте количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте количество столбцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        void PrintArray(double[,] twodimArray) //метод вывода массива на печать
        {
            for (int i = 0; i < twodimArray.GetLength(0); i++) //цикл для задания строк
            {
                for (int j = 0; j < twodimArray.GetLength(1); j++) //цикл для задания столбцов
                {
                    Console.Write("{0,6:F1}", twodimArray[i, j]);
                }
                Console.WriteLine();
            }
        }

        void FillArray(double[,] twodimArray) //метод заполнения массива
        {
            for (int i = 0; i < twodimArray.GetLength(0); i++) //цикл для задания строк
            {
                for (int j = 0; j < twodimArray.GetLength(1); j++) //цикл для задания столбцов
                {
                    twodimArray[i, j] = new Random().NextDouble() * 100;
                }
            }
        }
        double[,] matrix = new double[rows, columns];
        FillArray(matrix);
        PrintArray(matrix);
    }
}