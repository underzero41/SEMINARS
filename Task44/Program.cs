﻿// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] Fibo(int number)
{
    int[] arr = new int[number];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }
    return arr;
}
Console.Write(string.Join(" ", Fibo(number)));

