// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Напишите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1>number2 & number1>number3){
    Console.Write("Максимальное число -> " + number1);
}
else if (number2>number1 & number2> number3){
    Console.Write("Максимальное число -> " + number2);
}
else if (number3>number1 & number3>number2){
    Console.Write("Максимальное число -> " + number3);
}