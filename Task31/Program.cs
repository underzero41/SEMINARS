﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] arr = new int[12];
int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-9,10);
    Console.Write($"{arr[i]}, ");
    if (arr[i] < 0) sumNeg += arr[i];
    else sumPos += arr[i];
}
Console.WriteLine("\b\b ");

Console.WriteLine($"Sum of positive numbers is {sumPos}");
Console.WriteLine($"Sum of negative numbers is {sumNeg}");