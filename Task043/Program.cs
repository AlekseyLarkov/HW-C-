// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputNumber(string text)
{
    Console.Write($"Введите значение {text}: ");
    string noconvert = Console.ReadLine();
    int numb = Convert.ToInt32(noconvert);
    return numb;
}
double FindingX(int numK1, int numK2, int numB1, int numB2)
{
    double result = (numB2 - numB1) / (numK1 - numK2);
    return result;
}
double FindingY(int numK1, int numB1, double numX)
{
    double result = (numK1 * numX) + numB1;
    return result;
}

int b1 = InputNumber("b1");
int b2 = InputNumber("b2");
int k1 = InputNumber("k1");
int k2 = InputNumber("k2");
double x = FindingX(k1, k2, b1, b2);
double y = FindingY(k1, b1, x);
Console.WriteLine($"Точка пересечения прямых -> ({x} ; {y})");
