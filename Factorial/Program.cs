//Нахождение факториала

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum= 0;
int count= 1;

while (sum<number){
    sum+=1;
    count=sum*count;
    
}
Console.Write(count);