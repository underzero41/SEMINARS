//Нахождение среднестатистического числа

Console.Write("Введите первое число: ");
double numberA = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberB = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double numberC = double.Parse(Console.ReadLine());
Console.Write("Введите четвертое число: ");
double numberD = double.Parse(Console.ReadLine());
double count = ((numberA+numberB+numberC+numberD)/4);
Console.Write(count);