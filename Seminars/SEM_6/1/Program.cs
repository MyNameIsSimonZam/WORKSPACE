// // Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// // [1 2 3 4 5] -> [5 4 3 2 1]

// // [6 7 3 6] -> [6 3 7 6]

// int[] array = GetArray(5, 0, 10);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] resultArray = ReverseArray2(array);
// Console.WriteLine($"[{String.Join(", ", resultArray)}]");

// ReverseArray1(array);
// Console.WriteLine($"[{String.Join(", ", array)}]");



// // Первый вариант разворота массива
// void ReverseArray1(int[] inArray){
//     for(int i = 0; i < inArray.Length / 2; i++){
//         int temp = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = temp;
//     }
// }

// // Второй вариант разворота массива
// int[] ReverseArray2(int[] inArray){
//     int[] result = new int[inArray.Length];
//     for(int i = 0; i < inArray.Length; i++){
//         result[i] = inArray[inArray.Length - i - 1];
//     }
//     return result;
// }


// // Functions
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

//**Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.

//<aside>
//❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

//</aside>


// Console.Write("Введите 1 сторону треугольника: ");
// int A = int.Parse(Console.ReadLine()!);

// Console.Write("Введите 2 сторону треугольника: ");
// int B = int.Parse(Console.ReadLine()!);

// Console.Write("Введите 3 сторону треугольника: ");
// int C = int.Parse(Console.ReadLine()!);

// if(GetTriangle(A, B, C)) Console.Write($"Треугольник с длинами {A} {B} {C} существует");
// else Console.Write($"Треугольник с длинами {A} {B} {C} не существует");

// //Метод сравнения сторон
// bool GetTriangle(int A, int B, int C)
// {
// if((A < B+C) && (B < A+C) && (C < A+B)) return true;
// else return false;
// }