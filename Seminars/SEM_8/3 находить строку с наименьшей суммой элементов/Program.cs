/* Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка
*/

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

while (rows == columns  rows == 0  columns == 0)
{
    Console.WriteLine("Введите значения отличные друг от друга или ноля");
    Console.Write("Введите количество строк: ");
    rows = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов: ");
    columns = int.Parse(Console.ReadLine()!);
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($"Номер строки с минимальной суммой равен {ArrayMin(array)} ");

int ArrayMin(int[,] inArray)
{
    int minSum = 0;
    int sum = 0;
    int minRow = 0;

    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        minSum += inArray[0, j];
    }

    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = inArray[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }

    }
    return minRow + 1;
}

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