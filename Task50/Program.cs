// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

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

Console.WriteLine();
PrintArray(array);

Console.WriteLine();
Console.Write("Input line index X: ");
int indexX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column index Y: ");
int indexY = Convert.ToInt32(Console.ReadLine());



void GetValueArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (indexX >= arr.GetLength(0) || indexY >= arr.GetLength(1))
            {
                Console.WriteLine("Wrong number!");
                break;
            }
            else
            {
            Console.WriteLine(arr[indexX, indexY]);
            break;
            }
        }
        break;
    }
}
  

GetValueArray(array);