// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// Прим: А(3,6,8); В(2,1,-7) -> 15.84

Console.WriteLine("Set point A coordinates");
Console.Write("X = ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("X = ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Point A({xa};{ya};{za})");

Console.WriteLine("Set point B coordinates");
Console.Write("X = ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("X = ");
int zb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Point B({xb};{yb};{zb})");

double Distance3D(int xa,int ya,int za,int xb,int yb,int zb)
{
    double distanseXZ = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(za - zb, 2));

    double distance = Math.Sqrt(Math.Pow(distanseXZ, 2) + Math.Pow(ya - yb, 2));
    return distance;
}

Console.WriteLine("Distance between A and B is "+Distance3D(xa, ya, za, xb, yb,zb));

/*
double Distanse(int x1, int y1, int x2, int y2)
{
    double distanse = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return distanse;
}

Console.WriteLine("Distance between A and B is "+Distanse(xa, ya, xb, yb));
*/