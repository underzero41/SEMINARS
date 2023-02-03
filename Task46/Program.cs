// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Write("Input size of array m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size of array n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(-9, 10);
    }
}

PrintArray(array);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{arr[i,j]}\t");
    }
    Console.WriteLine();
}
}