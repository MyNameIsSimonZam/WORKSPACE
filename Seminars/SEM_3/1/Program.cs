/*Напишите программу,
которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).*/

Console.Write("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine()!);

switch (a)
{
case 1:
{
Console.WriteLine("В данной четверти х>0 и у >0.");
break;
}
case 2:
{
Console.WriteLine("В данной четверти х<0 и у>0.");
break;
}
case 3:
{
Console.WriteLine("В данной четверти х<0 и у<0.");
break;
}
case 4:
{
Console.WriteLine("В данной четверти х>0 и у<0.");
break;
}
default:
{
Console.WriteLine("Это значение вне диапазона");
break;
}
}