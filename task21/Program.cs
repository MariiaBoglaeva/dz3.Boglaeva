// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.WriteLine("x: ");
int firstX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int firstY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z: ");
int firstZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.WriteLine("x: ");
int secondX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int secondY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z: ");
int secondZ = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double result = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
    result = Math.Round(result, 2, MidpointRounding.ToZero);
    return result;
}
double dist = Distance(firstX, firstY, firstZ, secondX, secondY, secondZ);
System.Console.WriteLine($"искомое расстояние -> {dist}");