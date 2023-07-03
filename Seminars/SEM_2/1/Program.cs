// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
int num1 = number / 10;
int num2 = number % 10;

int max = num1;

if (max < num2)
{
    max = num2;
}

Console.WriteLine($"Наибольшая цифра числа {number} = {max}");
