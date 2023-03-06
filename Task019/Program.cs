// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool CheckNum(int num1, int num2)
{
    return(num1 == num2);
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 99999)
{
    int FirstTwoNum = number / 1000;
    int LastTwoNum = number % 100;
    int PreLastNum = LastTwoNum / 10;
    int LastNum = LastTwoNum % 10;
    int LastNumCheck = LastNum * 10 + PreLastNum;
    Console.WriteLine(CheckNum(FirstTwoNum, LastNumCheck) ? "Да" : "Нет");
}
else
{
    Console.WriteLine("Требуется пятизначное число");
}