// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int num = InputNumber("Input number: ");
int count = 1;

void PrintNumbers(int num, int count)
{
    if(count > num) return;
    PrintNumbers(num, count +1);
    Console.Write(count + ", ");
}

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

Console.Write($"N = {num} -> ");
PrintNumbers(num, count);
Console.Write("\b\b  ");