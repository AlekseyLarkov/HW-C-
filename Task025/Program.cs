// Напишите цикл, который принимает на вход два числа (А и В) 
// ивозводит число А в натуральную степень В.
// 3,5 -> 243
// 2,4 -> 16

int Degree(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)
{
    int degree = Degree(a, b);
    Console.WriteLine($"Число {a} в степени {b} = {degree}");
}
else
{
    Console.WriteLine($"Введите положительное число b");
}


