// Напишите программу, которая будет создавать копию заданного массива с помощью 
// поэлементного копирования

int[] array = new int[6];

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

int[] CopyArray(int[] array){
  int[] copyArray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    copyArray[i] = array[array.Length - 1- i];
  }
  return copyArray;
}

FillArray(array);
WriteArray(array);
int[] copyArray = CopyArray(array);
WriteArray(copyArray);
