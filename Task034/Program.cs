// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.

void FillArray(int[] arr, int arrSize)
{
    Random R = new Random();
    for (int i = 0; i < arrSize; i++)
    {
        arr[i] = R.Next(100, 1000);
    }
}
int NumberOfEven(int[] arr, int arrSize)
{
    int result = 0;
    for (int i = 0; i < arrSize; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    return result;
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

int arraySize = 10;
int[] array = new int[arraySize];
FillArray(array, arraySize);
Console.WriteLine("Заданный массив");
PrintArray(array, arraySize);
int numberOfEven = NumberOfEven(array, arraySize);
Console.WriteLine($"Количество четных чисел в заданном массиве = {numberOfEven}");