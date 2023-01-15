//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
double number = double.Parse(Console.ReadLine());
double current = -1*number;
while(current<=number){
    Console.Write($"{current}, ");
    current++;
}
Console.Write("\b\b     ");