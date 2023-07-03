// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()!);
// вводим 4 и 2 

if (num1 / num2 == num2 || num2 / num1 == num1)
{
    Console.WriteLine("Является");
}
else Console.WriteLine("Не является");