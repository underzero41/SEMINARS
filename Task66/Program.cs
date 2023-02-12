// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputNumbers("Input number M: ");
int n = InputNumbers("Input number N: ");
int temp = m;

if(m > n)
{
    m = n;
    n = temp;
}

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if(n <= m)
    {
        Console.Write($"Summ of elements = {sum}");
        return;
    }
    PrintSum(m, n - 1, sum);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

PrintSum(m, n, temp = 0);