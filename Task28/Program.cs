// Напишите программу которая принимает на вход число N и выдает произведение чисел от 1 до N

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int prod(int Prod)
{
    int count = 1;
    for (int i = 1; i <= Prod; i++)
    {
        count *= i;
    }
    return count;
}
Console.WriteLine($"Product from 1 to {number} equel {prod(number)}");