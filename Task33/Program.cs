// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] arr = new int[5];
void FillandPrintArray (int[] arr)
{
    Console.Write('[');
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(']');
}
FillandPrintArray(arr);


Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(arr.Contains(number) || arr.Contains(number * -1)) Console.WriteLine("Yes");
else Console.WriteLine("No");

// for (int i = 0; i < arr.Length; i++)
// {
//     if(number == arr[i] || number * -1 == arr[i]) 
//     {
//         Console.WriteLine("Yes");
//         return;
//     }
//     else Console.WriteLine("No");
// }
