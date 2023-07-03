// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// 7 -> 28

// 4 -> 10

// 8 -> 36

Console.Write("Введите число: ");
int limit = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {limit} равна {GetSum(limit)}");

// Функция подсчета суммы от 1 до А
int GetSum(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum = sum + i; // sum += i
    }
    return sum;
}