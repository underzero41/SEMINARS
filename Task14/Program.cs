// Напишите программу, которая на вход принимает число и проверяет,
//кратно ли одновременно 7 и 23.
//&&- логическое И
//||- логическое ИЛИ

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num%23==0 && num%7==0){
    Console.WriteLine($"{num} кратно 7 и 23, это успех!");
}
else{
    Console.WriteLine($"{num} не кратно 7 и 23, это провал!");
}