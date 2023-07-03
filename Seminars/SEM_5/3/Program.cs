// **Задача 32:** Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");


for ( int i = 0; i < size; i++)
{
    array[i] *= -1;
}

Console.WriteLine($"[{String.Join(", ", array)}]");

// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-200, 200);
    }
    return result;
}