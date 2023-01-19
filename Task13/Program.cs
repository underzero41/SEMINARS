// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
string numtxt = Convert.ToString(num);
if (numtxt.Length > 2){
  Console.WriteLine("Third number -> " + numtxt[2]);
}
else {
  Console.WriteLine("There isnt third number");
}