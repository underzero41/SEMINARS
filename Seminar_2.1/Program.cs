﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру из этого числа.
int num = new Random().Next(100, 1000);
//Console.WriteLine(num);
int num1 = num/100;
int num2 = num%10;
Console.WriteLine($"{num} -> {num1}{num2}");
