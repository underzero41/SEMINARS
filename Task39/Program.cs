// Напишите прорамму, которая перевернет однмерный массив
// (последний элемент будет на первом месте а первый на последнем и тд.)
// [1 2 3 4 5] -> [5 4 3 2 1]

// int[] arr = new int[5];

// Console.Write("[");
// RandomNumbers(arr);
// Console.Write("\b\b]");

// void RandomNumbers(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1,100);
//         Console.Write(arr[i] + ", ");
//     }
// }

Console.WriteLine("Input size of array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimum of array: ");
int minArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of array: ");
int maxArr = Convert.ToInt32(Console.ReadLine());

int[] GetArr(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minArr, maxArr + 1);
    } 
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    } 
    Console.Write("\b\b]");
    Console.WriteLine();
}

void ReverseArray(int[] arr)
{
    Console.Write("[");
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b]");
}

int[] array = GetArr(n);
PrintArr(array);
ReverseArray(array);
