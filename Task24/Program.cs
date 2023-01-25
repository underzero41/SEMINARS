// Напишите программу которая на вход принимает число А и выдает сумму числе от 1 до А

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum(int Sum)
{
    int count = 0;
    for (int i = 1; i <= Sum; i++)
    {
        count += i;
    }
    return count;
}
Console.WriteLine($"Summary from 1 to {number} equel {sum(number)}");