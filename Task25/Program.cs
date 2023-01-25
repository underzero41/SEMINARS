// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

  Console.Write("Input first number: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input second number: ");
  int numberB = Convert.ToInt32(Console.ReadLine());


int Degree(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  int exponentiation = Degree(numberA, numberB);
  Console.WriteLine($"Number {numberA} in degree {numberB} is {exponentiation}");
