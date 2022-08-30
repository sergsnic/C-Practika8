// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] inputArray)
{
    Console.WriteLine("Результат: ");
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите к-во строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите к-во столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
int count = 1,
    rowsMin = 0,
    columnsMax = columns - 1,
    rowsMax = rows - 1,
    columnsMin = 0;

while (rowsMin < rows)
{
    // движение направо
    for (int j = columnsMin; j < columns; j++)
    {
        int i = rowsMin;
        if (array[i, j] == 0) array[i, j] = count++;
    }
    // движение вниз
    for (int i = rowsMin + 1; i < rows; i++)
    {
        int j = columnsMax;
        if (array[i, j] == 0) array[i, j] = count++;
    }
    // движение налево
    for (int j = columnsMax - 1; j >= columnsMin; j--)
    {
        int i = rowsMax;
        if (array[i, j] == 0) array[i, j] = count++;
    }
    // движение вверх
    for (int i = rowsMax - 1; i > rowsMin; i--)
    {
        int j = columnsMin;
        if (array[i, j] == 0) array[i, j] = count++;
    }
    rowsMin++;
    columnsMax--;
    rowsMax--;
    columnsMin++;
}
PrintArray(array);

