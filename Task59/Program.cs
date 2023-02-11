// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

int[,] array = new int[4,4];
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

int[,] DeleteLineAndColumn(int[,] arr)
{
    int numMin = arr[0,0];
    int minI = 0;
    int minJ = 0;
    int[,] arr2 = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            minI = i;
            minJ = j;
        }
    }

    for (int k = 0; k < arr2.GetLength(0); k++)
    {
        for (int l = 0; l < arr2.GetLength(1); l++)
        {
            if(k >= minI && l >= minJ) arr2[k,l] = arr[k+1, l+1];
            else if(k >= minI) arr2[k,l] = arr[k+1, l];
            else if(l >= minJ) arr2[k,l] = arr[k, l+1];
            else arr2[k,l] = arr[k,l];
        }
    }
    return arr2;
}

PrintArray(array);
Console.WriteLine();

int[,] arr2 = DeleteLineAndColumn(array);
PrintArray(arr2);