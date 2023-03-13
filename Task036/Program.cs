// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

void FillArray(int[] arr, int arrSize)
{
    Random R = new Random();
    for (int i = 0; i < arrSize; i++)
    {
        arr[i] = R.Next(0, 20);
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
int Sum(int[] arr, int arrSize)
{
    int result = 0;
    for (int i = 0; i < arrSize; i++)
    {
        if (i % 2 == 1)
        {
            result = result + arr[i];
        }
    }
    return result;
}

int Size = new Random().Next(0, 10);
int[] array = new int[Size];
FillArray(array, Size);
Console.WriteLine("Заданный массив");
PrintArray(array, Size);
int sum = Sum(array, Size);
Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");