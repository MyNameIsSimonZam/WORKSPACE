// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].

int[] array = GetArray(123);
Console.WriteLine($"[{String.Join(", ", array)}]");
int count = 0;

foreach(int el in array)
{
    count += el <= 99 && el >= 10 ? 1 : 0;
}

Console.WriteLine($"Значения в отрезке: {count}");

// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 1001);
    }
    return result;
}

