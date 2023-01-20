// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number/10;
int number2 = number1%10;    
if(number>=1000 || number<=99){
    Console.WriteLine("The number is not correct, try one more time.");
}
else{
    Console.WriteLine($"{number} -> {number2}");
}
