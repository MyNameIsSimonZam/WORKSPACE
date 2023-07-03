// Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine()!);

int kr = num1 % num2;
if (kr == 0)
{
      Console.WriteLine($"Кратно");
}
else
{
      Console.WriteLine($"Не кратно, остаток {kr}");
}