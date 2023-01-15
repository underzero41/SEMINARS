//Напишите программу кторая на вход принимает трехзначное число, а на выходе показывает последнюю цифру этого числа.

Console.Write("Input three digit number: ");
int number = int.Parse(Console.ReadLine());
Console.Write(number + " -> ");

Console.Write(number%10 + " ");