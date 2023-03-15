// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNumber(string text)
{
    Console.Write($"Введите значение {text}: ");
    string noconvert = Console.ReadLine();
    double numb = Convert.ToInt32(noconvert);
    return numb;
}
double FindingX(double numK1, double numK2, double numB1, double numB2)
{
    double result = (numB2 - numB1) / (numK1 - numK2);
    return result;
}
double FindingY(double numK1, double numB1, double numX)
{
    double result = (numK1 * numX) + numB1;
    return result;
}

double b1 = InputNumber("b1");
double b2 = InputNumber("b2");
double k1 = InputNumber("k1");
double k2 = InputNumber("k2");
double x = Math.Round(FindingX(k1, k2, b1, b2), 2);
double y = Math.Round(FindingY(k1, b1, x), 2);
Console.WriteLine($"Точка пересечения прямых -> ({x} ; {y})");
