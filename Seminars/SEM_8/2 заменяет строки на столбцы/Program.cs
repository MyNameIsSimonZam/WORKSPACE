﻿/*Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

В итоге получается вот такой массив:

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7*/


Console.Write("Введите количество строк и столбцов: ");
int rows = int.Parse(Console.ReadLine()!);
int columns = rows;


int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();

PrintArray(ChangeArray(array));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] inArray)
{
    int[,] change = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            change[i, j] = inArray[j, i];
        }
    }

    return change;
}