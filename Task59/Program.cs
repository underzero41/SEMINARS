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
    int numIndx1 = 0;
    int numIndx2 = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] < numMin) 
            {
                numMin = arr[i,j];
                numIndx1 = i;
                numIndx2 = j;
            }    
        }
    }
    int[,] arr2 = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0, k = 0; i < arr2.GetLength(0); i++, k++)
    {
        for (int j = 0, l = 0; j < arr2.GetLength(1); j++, l++)
        {
            if(i == numIndx1)
            {
                i++;
            }
            if(j == numIndx2)
            {
                j++;
            }
            if(i == arr.GetLength(0) || j == arr.GetLength(1))
            {
                continue;
            }
            arr2[k,l] = arr[i,j];
        }
    }
    return arr2;
}

PrintArray(array);
Console.WriteLine();

int[,] arr2 = DeleteLineAndColumn(array);
PrintArray(arr2);