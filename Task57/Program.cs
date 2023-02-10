// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь
// содержит информацию о том, сколько раз встречается элемент входных данных.
int[,] array = new int[5, 5];
array = GenerateArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}");
        }
        Console.WriteLine();
    }
}
int[,] GenerateArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}
int[] ArrayToString(int[,] arr)
{
    int[] newArray = new int[arr.GetLength(0) * arr.GetLength(1)];
    int i = 0;
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            newArray[i] = arr[row, col];
            i++;
        }
    }
    return newArray.Distinct().ToArray();
}    

void FindQuanityOfEachElementValue(int[,] arr, int[] uniqueArray)
{
    int count;
    for (int i = 0; i < uniqueArray.Length; i++)
    {
        count = 0;
        int num = uniqueArray[i];
        Console.Write($"Quanity of {num} -> ");
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if(num == arr[row,col])
                {
                    count ++;
                }
            }
        }
        Console.WriteLine(count);
    }
}



Console.WriteLine();
PrintArray(array);
Console.WriteLine();

FindQuanityOfEachElementValue(array, ArrayToString(array));
