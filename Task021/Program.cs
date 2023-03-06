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
int x1 = Сoordinate("x1: ");
int y1 = Сoordinate("y1: ");
int z1 = Сoordinate("z1: ");
int x2 = Сoordinate("x2: ");
int y2 = Сoordinate("y2: ");
int z2 = Сoordinate("z2: ");

double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine($"Расстояние между точками = {Math.Round(dist, 2)}");