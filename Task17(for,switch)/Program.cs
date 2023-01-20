// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Input x:" );
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0) Console.WriteLine("1");
else if(x < 0 && y > 0) Console.WriteLine("2");
else if(x < 0 && y < 0) Console.WriteLine("3");
else if(x > 0 && y < 0) Console.WriteLine("4");
else Console.WriteLine("Error");


// Как использовать цикл for
// Console.Write("Input num:" );
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i=0; i<=num; i++){
//     Console.Write($"{i} ");
// }


// использование функции Switch
// Console.Write("Input num:" );
// int num = Convert.ToInt32(Console.ReadLine());
// switch(num){
//     case 1:
//     {
//         Console.WriteLine("one");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("two");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("three");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("No data");
//         break;
//     }
// }        