// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

Console.Write("Please enter a number: ");

int number = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= number; i++)
{
int sqr = Convert.ToInt32(Math.Pow(i, 2));
Console.WriteLine(sqr);
}