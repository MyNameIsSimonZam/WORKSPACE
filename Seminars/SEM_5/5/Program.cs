// **Задача 37:** Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

Console.Write("Please enter the array size: ");
int size = int.Parse(Console.ReadLine()!);

int[] numbers = new int[size];
numbers = GetArray(numbers);

Console.WriteLine($"The sum of number pairs in the array [{String.Join(", ", numbers)}] is [{String.Join(", ", ProductPairs(numbers))}]");

int[] GetArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

//произведение пар чисел
int[] ProductPairs(int[] arr){
    int size = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] productArray = new int[size];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        productArray[i] = arr[i] * arr[arr.Length - i - 1];

    }
    if(arr.Length % 2 != 0) {
        productArray[size - 1] = arr[arr.Length / 2];
    }
    return productArray;
}