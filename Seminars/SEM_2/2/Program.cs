// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int num1 = number / 100;
int num3 = number % 10;

int num = num1 * 10 + num3;


Console.WriteLine($"Первая и третья цифра {number} = {num}");
