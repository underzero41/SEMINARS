// Напишите программу которая принимает на вход число и выдает количество цифр в числе

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int nums = 0;
int count = number;

while(count > 0)
{
    count /= 10;
    nums++;
}

Console.WriteLine($"In number {number} -> {nums} numbers");
