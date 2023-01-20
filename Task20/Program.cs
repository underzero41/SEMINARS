// Задача №20.
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
// double x3 = x1-x2; //2
// Console.WriteLine(x3);
// double y3 = y1-y2; //2
// Console.WriteLine(y3);
// double x4 = x3*x3; //4
// Console.WriteLine(x4);
// double y4 = y3*y3; //4
// Console.WriteLine(y4);
// double result = x4+y4; //8
double result = Math.Sqrt((Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)));
Console.WriteLine(result);

