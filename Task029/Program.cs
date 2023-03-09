// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void FillArray(int[] arr, int size)
{
    Random R = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = R.Next(0, 50);
    }
}
void PrintArray(int[] arr, int size)
{
    Console.Write($"[{arr[0]}, ");
    for (int i = 1; i < size - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[size - 1]}]");
}

int length = 8;
int[] array = new int[length];
FillArray(array, length);
PrintArray(array, length);