// Задача 38: Задайте массив целых чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] arr = new int[10];

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,100);
        Console.Write(arr[i] + ", ");
    }
Console.Write("\b\b]");

int max = arr[0];
int min = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if(max < arr[i]) max = arr[i];
    if(min > arr[i]) min = arr[i];
}

int result = max - min;
Console.Write($" -> {result}");
Console.WriteLine($"\nDifference between maximum {max} and minimum {min} value is {result}");
