// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int CheckNumber(int[,,] inputArray)
{
    int number = 0;
    bool flag = true;
    while (flag == true)
    {
        number = new Random().Next(10, 100);
        flag = false;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                for (int k = 0; k < inputArray.GetLength(2); k++)
                {
                    if (inputArray[i, j, k] == number) flag = true;
                }
            }
        }
    }
    return number;
}

Console.Write("Введите к-во строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите к-во столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] inputArray = new int[rows, columns, depth];
Console.WriteLine("Исходный массив:");
for (int i = 0; i < inputArray.GetLength(0); i++)
{
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        for (int k = 0; k < inputArray.GetLength(2); k++)
        {
            inputArray[i, j, k] = CheckNumber(inputArray);
            Console.Write($"{inputArray[i, j, k]} ({i},{j},{k})\t");
        }
        Console.WriteLine();
    }
}
