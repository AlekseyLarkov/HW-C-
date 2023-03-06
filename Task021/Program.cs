// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Сoordinate(string text)
{
    Console.Write($"Введите координату {text}");
    string noconvert = Console.ReadLine();
    int coord = Convert.ToInt32(noconvert);
    return coord;
}
int QuadKat(int num1, int num2)
{
    int result = (num2 - num1) * (num2 - num1);
    return result;
}
int x1 = Сoordinate("x1: ");
int y1 = Сoordinate("y1: ");
int z1 = Сoordinate("z1: ");
int x2 = Сoordinate("x2: ");
int y2 = Сoordinate("y2: ");
int z2 = Сoordinate("z2: ");

double dist = Math.Sqrt(QuadKat(x1, x2) + QuadKat(y1, y2) + QuadKat(z1, z2));
Console.WriteLine($"Расстояние между точками = {Math.Round(dist, 2)}");