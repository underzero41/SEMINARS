// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"How many numbers do you want? ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Input {i+1} number: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] arrNums)
{
  int count = 0;
  for (int i = 0; i < arrNums.Length; i++)
  {
    if(arrNums[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Numbers > 0: {Comparison(arr)} ");
