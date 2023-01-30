// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[10];
int sumEven= 0;

FillandPrintArray(arr);
Console.Write(" -> ");
FindEvenNumbers(sumEven);

void FillandPrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
    arr[i] = new Random().Next(100,1000);
    Console.Write(arr[i]+ " ");
    }
    Console.Write("\b]");
}

void FindEvenNumbers(int sumEven)
{ 
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] %2 == 0) sumEven ++;
    }   
    Console.Write(sumEven);
}
