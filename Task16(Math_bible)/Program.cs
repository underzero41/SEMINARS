//Напишите программу, которая принимает на вход два числа и проверяет, является ли
//одно число квадратом другого.


Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1*num1==num2){
    Console.WriteLine($"Number {num2} is a square root of {num1}, cool, you are the best dev!");
}
else if (num2*num2==num1){
    Console.WriteLine($"Number {num1} is a square root of {num2}, cool, you are the best dev!");    
}
else{
    Console.WriteLine($"Number {num1} is not a square root of {num2}, sh*t! But you are cool, however");
}

// Console.Write("input number: ");
// double num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Pow(num,3)); //степень
// Console.WriteLine(Math.Sqrt(num)); //корень
// Console.WriteLine(Math.Round(num)); //округление
// Console.WriteLine(Math.Abs(num)); //из отрицательного в положительное

