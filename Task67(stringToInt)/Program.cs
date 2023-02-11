// Напишите программу которая на вход будет принимать число и возвращать сумму его цифр
// 453 -> 12
// 45 -> 9

int num = InputNumbers("Input number: ");
int sum = SumNuber(num);

int SumNuber(int num)
{
    if(num > 1) return num % 10 + SumNuber(num/10);
    else return 0;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

Console.WriteLine($"{num} -> {sum}");