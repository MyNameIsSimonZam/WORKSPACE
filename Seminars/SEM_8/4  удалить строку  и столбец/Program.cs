//Задача 59: Из двумерного массива целых чисел удалить строку 
// и столбец, на пересечении которых расположен наименьший элемент.





using System.Globalization;

Console.WriteLine("Введите кол-во строк");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int col = int.Parse(Console.ReadLine());
int[,] arr = new int[row, col];


arr = getArr(arr); //Из двумерного массива целых чисел
PrintArray(arr); 

delColRow(arr, searchMin(arr));


int[, ] getArr(int[, ] arr)
{
  Random rnd = new Random();
  for (int i = 0; i < arr.GetLength(0); ++i)
  {
    for (int j = 0; j < arr.GetLength(1); ++j)
    {
      arr[i, j] = rnd.Next(100);
    }
  }

return arr;
}

int[] searchMin(int[, ] arr)
{
    int[] temp =new int[]{0, 0};
    int min = arr[0, 0];   

    for (int i = 0; i < arr.GetLength(0); ++i)
    {
        for (int j = 0; j < arr.GetLength(1); ++j)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                temp[0] = i; 
                temp[1] = j;
            }
        }
    }

    return temp;
}

void delColRow(int[,] arr, int[] temp)
{
    int[,] tempArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int row = 0;
    int col = 0;
    for (int i = 0; i < arr.GetLength(0); ++i)
    {
        if (i == temp[0])
            continue;
        for (int j = 0; j < arr.GetLength(1); ++j)
        {
            if (j == temp[1])
                continue;
            tempArr[row, col] = arr[i, j];
            col++;
        }
        //if (i != temp[0] && j != temp[1])
        //{
        //    ++row;
        //    col = 0;
        //}
        ++row;
        col = 0;
    }
    PrintArray(tempArr);
}

void PrintArray(int[,] inArray)
{
    Console.WriteLine();
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}