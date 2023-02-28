// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого цисла.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNumb(int numb)
{
    int SecLastDigit = numb % 100;
    int SecDigit = SecLastDigit / 10;
    return SecDigit;
}

Console.WriteLine("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100 && number < 1000) 
{
    int secondNumb = SecondNumb(number);
    Console.WriteLine($"Вторая цифра числа {number} является {secondNumb}");
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}