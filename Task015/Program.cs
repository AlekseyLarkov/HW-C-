// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет



Console.WriteLine("Введите целое число: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine($"Цифра {day} является выходным");
    }
    else
    {
        Console.WriteLine($"Цифра {day} не является выходным");
    }
}
else 
{
    Console.WriteLine($"Цифра {day} не является днем недели");
}