// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


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
            Console.Write($"{matr[i, j], 3} ");
        }
        Console.WriteLine("|");
    }
}
bool CheckElementMatrix(int[,] matrx, int x, int y)
{
    return x < matrx.GetLength(0) && y < matrx.GetLength(1) && x > 0 && y > 0;
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату элемента ");
Console.Write("строка: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("столбец: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(row, column);
PrintMatrix(matrix);
Console.WriteLine(CheckElementMatrix(matrix, m, n) ? $"Данный элемент равен {matrix[m - 1, n - 1]}" : "Такого элемента не существует");
