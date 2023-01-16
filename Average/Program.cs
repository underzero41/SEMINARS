//Нахождение среднестатистического числа

Console.Write("Введите первое число: ");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
double numberC = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите четвертое число: ");
double numberD = Convert.ToInt32(Console.ReadLine());
double count = ((numberA+numberB+numberC+numberD)/4);
Console.Write(count);