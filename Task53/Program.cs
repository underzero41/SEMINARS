// Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

int[,] array = new int[5, 5];
array = FillArray(array);


int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 11);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();
    }
}

void ChangeLinesArray(int [,] arr)
{
   int[] temp = new int[arr.GetLength(1)];
   for (int j = 0; j < arr.GetLength(1); j++)
   {
        temp[j] = arr[0,j];
        arr[0,j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = temp[j];
   }
}


Console.WriteLine();
PrintArray(array);
Console.WriteLine();
ChangeLinesArray(array);
PrintArray(array);