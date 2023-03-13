// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.

void FillArray(double [] arr, int arrSize)
{
    Random R = new Random();
    for (int i = 0; i < arrSize; i++)
    {
        arr[i] = R.NextDouble();
        double a = R.Next(1, 50);
        arr[i] = Math.Round (arr[i] * a, 1);
    }
}
void PrintArray(double [] arr, int arrSize)
{
    Console.Write($"[{arr[0]}, ");
    for (int i = 1; i < arrSize - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arrSize - 1]}]");
}
double Max(double[] arr, int arrSize)
{
    double result = arr[0];
    for (int i = 1; i < arrSize; i++)
    {
        if(arr[i] > result)
        {
            result = arr[i];
        }
    }
    return result;
}
double Min(double[] arr, int arrSize)
{
    double result = arr[0];
    for (int i = 1; i < arrSize; i++)
    {
        if(arr[i] < result)
        {
            result = arr[i];
        }
    }
    return result;
}

int Size = 8;   //new Random().Next(3, 10)
double[] array = new double[Size];
FillArray(array, Size);
Console.WriteLine("Заданный массив");
PrintArray(array, Size);
double max = Max(array, Size);
double min = Min(array, Size);
Console.WriteLine($"Разница между Max и Min = {max - min}");
