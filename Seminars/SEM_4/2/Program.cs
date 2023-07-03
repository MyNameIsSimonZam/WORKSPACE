// // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5

Console.Write("Please enter a number: ");
int Number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Number} -> {SumNumber(Number)}");

int SumNumber(int A)
{
    int count = 0;
    while (A > 0)
    {
        count++;
        A /= 10;
    }
    return count;
}

