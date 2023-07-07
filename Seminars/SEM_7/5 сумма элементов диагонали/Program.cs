// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
//  находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] get2dArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void getSum(int[,] array)
{
    // 0,1,2
    // 1,2,3
    // 1,2,2
    // 2,3,3 

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    int number = 0;
    if (rows > columns)
    {
        number = columns;
    }
    else
    {
        number = rows;
    }

    int[] numbers = new int[number];
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                numbers[i] = array[i, j];
                sum += array[i, j];
            }
        }
    }

    Console.Write($"{String.Join(", ", numbers)} --> {sum}");
}


Console.Write("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = get2dArray(rows, columns, 0, 10);
print2dArray(array);
Console.WriteLine();
getSum(array);