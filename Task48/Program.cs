﻿// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Write("Input size of array m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size of array n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = i + j;
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{array[i,j],4}");
    }
    Console.WriteLine();
}
}

PrintArray(array);