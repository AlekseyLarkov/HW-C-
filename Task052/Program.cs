// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrx = new int[rows, columns];
    Random R = new Random();
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        for (int j = 0; j < matrx.GetLength(1); j++)
        {
            matrx[i, j] = R.Next(0, 10);
        }
    }
    return matrx;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}
double[] ArithmeticMeanColumn(int[,] mtrx)
{
    double[] result = new double[mtrx.GetLength(1)];
    double sum = 0;
    int ind = 0;
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            sum = sum + mtrx[i,j];
        }
        result[ind] = Math.Round(sum / mtrx.GetLength(0), 2);
        sum = 0;
        ind++;
    }
    return result;
}
void PrintArray(double[] arr)
{
    Console.Write($"[{arr[0]}; ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i], 3}; ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(row, column);
PrintMatrix(matrix);
double[] arithmeticMeanColumn = ArithmeticMeanColumn(matrix);
PrintArray(arithmeticMeanColumn);
