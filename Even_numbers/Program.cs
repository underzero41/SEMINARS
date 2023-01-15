// Нахождение всех четных чисел до определенного
Console.Write("Напишите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0; //1
int count = 1; //2
while (count <= number){
    if (count%2==0){
        sum+=count;
        count+=count;   
    }
    else {
        count+=count;
    } 
    Console.Write($"{sum}, ");
}
//незаконченное 