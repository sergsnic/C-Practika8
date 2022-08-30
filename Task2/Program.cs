// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int rows, int columns)
{
    int[,] inputArray = new int[rows, columns];
    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i, j] = new Random().Next(11);
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return inputArray;
}

int MinRows(int[,] inputArray)
{
    int minSummRows = int.MaxValue, indexMinRows = int.MaxValue;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int summRows = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++) summRows += inputArray[i, j];
        if (summRows < minSummRows)
        {
            minSummRows = summRows;
            indexMinRows = i;
        }
    }
    return indexMinRows;
}

Console.Write("Введите к-во строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите к-во столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"номер строки с наименьшей суммой элементов: {MinRows(GetArray(rows, columns))}");