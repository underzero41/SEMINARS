// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Напишите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2){
    Console.WriteLine("Максимальное число: " + number1);
    Console.WriteLine("Минимальное число: " + number2);
}
else {
    Console.WriteLine("Максимальное число: " + number2);
    Console.WriteLine("Минимальное число: " + number1);
}
