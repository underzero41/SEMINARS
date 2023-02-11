// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int num = InputNumber("Input number: ");
int pow = InputNumber("Input pow: ");
int result = PowNum(num, pow);


int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int PowNum(int num, int pow)
{
    if(pow == 1) return num;
    else return num * PowNum(num, pow-1);
}

Console.WriteLine($"Num = {num}; Pow = {pow} -> {result}");