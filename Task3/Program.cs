//Напишите программу котораю будет на ввод принимать число, а на вывод выдавать день недели.

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number==1)
{
Console.Write("Понедельник");
}
if(number==2)
{
    Console.Write("Вторник");
}
if(number==3)
{
    Console.Write("Среда");
}
if(number==4)
{
    Console.Write("Четверг");
}
if(number==5)
{
    Console.Write("Пятница");
}
if(number==6)
{
    Console.Write("Суббота");
}
if(number==7)
{
    Console.Write("Воскресенье");
}