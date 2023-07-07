// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{Pow(A,B) }");

int Pow(int number, int rank){
    if(rank == 0) return 1;
    if(rank == 1) return number;
    return (number * Pow(number, rank-1));
}