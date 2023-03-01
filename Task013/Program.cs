// Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
//  645 -> 5
//  78 -> третьей цифры нет
//  32679 -> 6

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int thirdnum = num % 10;
    return thirdnum;
}
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine($"Третья цифра числа {number} является {thirdDigit}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}