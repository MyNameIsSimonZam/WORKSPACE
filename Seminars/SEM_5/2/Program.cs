//**Задача 33:** Задайте массив. Напишите программу, которая определяет,  
//присутствует ли заданное число в массиве.

//4; массив [6, 7, 19, 345, 3] -> нет

//3; массив [6, 7, 19, 345, 3] -> да


Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if(Answer(array, number) == true) Console.WriteLine("Да");
else Console.WriteLine("Нет");

//Метод поиска элемента 
bool Answer(int[] array, int number)
{
    foreach(int el in array)
    {
     if(el == number) return true;
    }
    return false;
}


// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 11);
    }
    return result;
}