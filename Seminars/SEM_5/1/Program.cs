﻿//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[{String.Join(", ", array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)
{
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
    // if(el > 0){
    //     positiveSum = positiveSum + el;
    // }
    // else{
    //     negativeSum = negativeSum + el;
    // }
}

Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum}");


// Функция заполнения массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}