// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 0;
while (current<=number){
    if (current%2==0){
        Console.Write($"{current}, ");
    }
    current+=1;
}
Console.Write("\b\b are even numbers.");    