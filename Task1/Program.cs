//Напишите код который на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.Write("Введите первое число: ");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberB = Convert.ToInt32(Console.ReadLine());
double result = Convert.ToInt32(Math.Pow(numberA, 2));
if (numberB == result)
{
    Console.Write("Первое число является квадратом второго.");
}
else
{
    Console.Write("Первое число не является квадратом второго.");
}