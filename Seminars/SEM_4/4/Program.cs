// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"От числа {N} произведения чисел {getMultiply(N)}");
int getMultiply(int limit)
{
    int res = 1;
    for (int i = 2; i <= limit; i++)
    {
        res *= i;
    }
    return res;
}
