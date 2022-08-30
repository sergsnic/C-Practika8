// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray(int rows, int Columns)
{
    int[,] inputArray = new int[rows, Columns];
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

int[,] MultipliedMatrix(int[,] inputArrayFirst, int[,] inputArraySecond)
{
    int size = inputArrayFirst.GetLength(0);
    int[,] outputArray = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < inputArrayFirst.GetLength(1); k++)
            {
                outputArray[i, j] = outputArray[i, j] + inputArrayFirst[i, k] * inputArraySecond[k, j];
            }
        }
    }
    return outputArray;
}

void PrintArray(int[,] inputArray)
{
    Console.WriteLine("Результат произведения двух матриц: ");
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите к-во строк в первом массиве: ");
int firstRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите к-во столбцов в первом массиве: ");
int firstColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите к-во строк во втором массиве: ");
int secondRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите к-во столбцов в втором массиве: ");
int secondColumns = Convert.ToInt32(Console.ReadLine());
if (firstRows != secondColumns || firstColumns != secondRows)
{
    Console.WriteLine("К-во строк в первой матрице не совпадает с к-вом столбцов во второй матрице");
    Console.WriteLine("или к-во столбцов в первой матрице не совпадает с к-вом строк во второй матрице");
    Console.WriteLine("Провести умножение двух матриц невозможно, введите корректные данные!");
    return;
}
Console.WriteLine("Первая матрица: ");
int[,] FirstArray = GetArray(firstRows, firstColumns);
Console.WriteLine("Вторая матрица: ");
int[,] SecondArray = GetArray(secondRows, secondColumns);
PrintArray(MultipliedMatrix(FirstArray, SecondArray));