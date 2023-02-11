// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if(start == end) return Convert.ToString(start);
    return (start + " " + PrintNumbers(start + 1, end));
}

Console.WriteLine($"N = {n} -> {PrintNumbers(1,n)}");