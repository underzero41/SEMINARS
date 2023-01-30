﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Console.Write("Введите колличество элементов в массиве: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];
FillArray(array);
PrintArray(array);
Console.Write(" -> ");
Console.Write(String.Join(", ", GetProductionPair(array)));

List<int> GetProductionPair(int[] array)
{
int lastElement = array.Length - 1;
int prod = 0;
List<int> result = new List<int>();

for (int i = 0; i < array.Length / 2; i++)
{
prod = array[i] * array[lastElement - i];
result.Add(prod);
}

if (array.Length % 2 == 1) result.Add(array[array.Length / 2]);
return result;
}


void FillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1, 100);
}
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.Write("]");
}