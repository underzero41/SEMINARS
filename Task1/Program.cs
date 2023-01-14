//Напишите код который на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.Write("Введите первое число: ");
double numberA = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberB = double.Parse(Console.ReadLine());
double result = Convert.ToInt32(Math.Pow(numberA, 2));
if (numberB == result)
{
    Console.Write("Первое число является квадратом второго.");
}
else
{
    Console.Write("Первое число не является квадратом второго.");
}