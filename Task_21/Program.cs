// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве


// int ya = Convert.ToInt32(Console.ReadLine());
// int xb = Convert.ToInt32(Console.ReadLine());
// int yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Set point A coordinates");
Console.Write("X = ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Point A({xa};{ya})");

Console.WriteLine("Set point B coordinates");
Console.Write("X = ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Point B({xb};{yb})");



double Distanse(int x1, int y1, int x2, int y2)
{
    double distanse = 0;
    distanse = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return distanse;
}

Console.WriteLine("Distance between A and B is "+Distanse(xa, ya, xb, yb));

// расстояние между точками = корень из суммы квадрата расстояния по Х и квадрата расстояния по Y
// 
//