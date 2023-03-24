//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDoubl(int rows, int columns)
{
    double[,] matrx = new double[rows, columns];
    Random R = new Random();
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        for (int j = 0; j < matrx.GetLength(1); j++)
        {
            matrx[i, j] = R.NextDouble();
            double rnd = R.Next(0, 12);
            matrx[i, j] = Math.Round (matrx[i, j] * rnd, 1);
        }
    }
    return matrx;
}
void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = CreateMatrixRndDoubl(m, n);
PrintMatrix(matrix);