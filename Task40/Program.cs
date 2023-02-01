// Напишите программу, которая на вход принимает три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

Console.Write("Input size of side A: ");
int sideA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input size of side B: ");
int sideB = Convert.ToInt32(Console.ReadLine());

Console.Write("Input size of side C: ");
int sideC = Convert.ToInt32(Console.ReadLine());

void CheckTringle(int sideA, int sideB, int sideC)
{
    if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB)
    {
        Console.WriteLine("Tringle ABC is correct");
    }
    else Console.WriteLine("Tringle ABC doesn't exist.");
}

CheckTringle(sideA, sideB, sideC);


// Console.WriteLine($"Side A is {sideA}; Side B is {sideB}; Side C is {sideC}");