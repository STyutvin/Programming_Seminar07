//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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
        for (int j = 0; j <  twodimArray.GetLength(1); j++) //цикл для задания столбцов
        {
            twodimArray[i, j] = new Random().Next(0,10);
        }
    }
}
Random rndRows = new Random();
Random rndcolumns = new Random();
int[,] matrix = new int[rndRows.Next(2,3), rndcolumns.Next(3,5)];
FillArray(matrix);
Console.Write("Задайте индекс элемента по строке: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте индекс элемента по столбцу: ");
int columnIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Создаю случайный двумерный массив... ");
Console.WriteLine("Массив создан!");
PrintArray(matrix);
int flag=0;
for (int i = 0; i < matrix.GetLength(0); i++) //цикл для задания строк
{
    for (int j = 0; j < matrix.GetLength(1); j++) //цикл для задания столбцов
    {
        if (i==rowIndex && j==columnIndex)
        {
            flag=1;
        }              
    }
}
if (flag==1) Console.WriteLine("Значение элемента по указанному индексу: " + matrix[rowIndex,columnIndex]);
else Console.WriteLine("Такого элемента нет.");
//if (flag) Console.WriteLine("Такого элемента нет.");
//Console.WriteLine(flag);
//else Console.WriteLine("Такого элемента нет.");