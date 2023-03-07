// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Table(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i, 3} -> {i*i*i, 3}");
        i++;
    }
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    Table(n);
}
else
{
    n = n * -1;
    Table(n);
}
