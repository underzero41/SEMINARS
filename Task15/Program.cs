// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Write the number for the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7) {
  Console.WriteLine($"{num} -> yes, today is a day off, take a break, relax");
  }
  else if (num < 1 || num > 7) {
    Console.WriteLine($"{num} -> It's not the day of the week, input range is 1 to 7, try one more time.");
  }
  else Console.WriteLine($"{num} -> Nope, today is a weekday, work hard, play hard.");