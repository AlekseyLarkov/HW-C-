// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int InputNumber(string text)
{
    Console.Write($"Введите число {text}: ");
    string noconvert = Console.ReadLine();
    int numb = Convert.ToInt32(noconvert);
    return numb;
}
void FillArrayUser(int[] arr, int arrSize)
{
    for (int i = 0; i < arrSize; i++)
    {
        Console.Write($"Введите элемент массива под номером {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] arr, int arrSize)
{
    Console.Write($"[{arr[0]}, ");
    for (int i = 1; i < arrSize - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arrSize - 1]}]");
}
int AmountPositive(int[] arr, int arrSize)
{
    int result = 0;
    for (int i = 0; i < arrSize; i++)
    {
        if (arr[i] > 0)
        {
            result++;
        }
    }
    return result;
}

int M = InputNumber("M");
int[] array = new int[M];
FillArrayUser(array, M);
PrintArray(array, M);
int amount = AmountPositive(array, M);
Console.WriteLine($"Вот столько ты ввел чисел больше 0 -> {amount}");