Console.WriteLine("Ввод координат точки A ");
Console.Write("Введите координаты точки xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки yA: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввод координат точки B ");
Console.Write("Введите координаты точки xB: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки yB: ");
int yB = Convert.ToInt32(Console.ReadLine());

double leng = Distance(xA, yA, xB, yB);
Console.WriteLine($"Расстояние между точкой A и точной B равно - {Math.Round(leng, 2, MidpointRounding.ToZero)}");

double Distance (int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}
