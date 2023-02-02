// Напишите программу которая будет преобразовывать десятичное число в двоичное.

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

string Perevod(int temp)
{
    string bin = "";
    // int i=0;
    int temp1 = 0;
    while(temp > 0)
    {
      temp1 = temp % 2;
      temp = temp / 2;
      bin = bin + temp1;
      // Console.Write(temp1);

    }
    return bin;
} 


string bin = Perevod(num);

Console.Write($"{num} -> ");
// tmp = 0;
for (int i = bin.Length - 1; i >= 0; i--)
{
  Console.Write($"{bin[i]} ");
}