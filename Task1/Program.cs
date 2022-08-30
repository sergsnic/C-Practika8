// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] ConvertArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            int temporaryVariable = 0;
            for (int k = j + 1; k < inputArray.GetLength(1); k++)
            {
                if (inputArray[i, k] > inputArray[i, j])
                {
                    temporaryVariable = inputArray[i, k];
                    inputArray[i, k] = inputArray[i, j];
                    inputArray[i, j] = temporaryVariable;
                }
            }
        }
    }
    return inputArray;
}
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
PrintArray(ConvertArray(GetArray(rows, columns)));