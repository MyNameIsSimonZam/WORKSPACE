// напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату x точки A: ");
int ax = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату y точки A: ");
int ay = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату x точки B: ");
int bx = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату y точки B: ");
int by = Convert.ToInt32(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow((bx-ax), 2)+Math.Pow((by-ay), 2));

Console.WriteLine($"Растояние между AB = {AB:f2}");