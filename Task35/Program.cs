// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] arr = new int[123];
FillArray(arr);
Console.Write(String.Join(", ", arr));
Console.Write(" -> ");
Console.WriteLine(CheckNumbers(arr));



void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
}

int CheckNumbers(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if(arr[i] >= 10 && arr[i] <= 99) counter++;
    }
    return counter;
}